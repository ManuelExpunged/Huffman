using Huffman.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Huffman
{
    public partial class Huffman : Form
    {
        public Huffman()
        {
            InitializeComponent();
        }

        private void Inputbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BinaryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            char[] chars = InputBox.Text.ToArray();

            Dictionary<char, int> numOfChar = new Dictionary<char, int>();

            foreach (char c in chars)
            {
                if (!numOfChar.ContainsKey(c))
                {
                    numOfChar.Add(c, 1);
                }
                else
                {
                    numOfChar[c]++;
                }
            }

            List<NodeModel> baseNodes = numOfChar.OrderByDescending(c => c.Value).Select(c => new NodeModel { Key = c.Key, Value = c.Value, Connector = ConnectorEnum.Connector.Empty }).ToList();
            List<NodeModel> huffman = CreateHuffmanTree(baseNodes);
            List<string> binaries = new List<string>();

            foreach (char c in InputBox.Text.ToArray())
            {
                foreach (NodeModel node in huffman)
                {
                    if (c == node.Key)
                    {
                        binaries.Add(Encode(string.Empty, node));
                    }
                }
            }

            BinaryBox.Text = string.Join(" ", binaries);
        }

        private List<NodeModel> CreateHuffmanTree(List<NodeModel> nodes)
        {
            List<NodeModel> childlessNodes = nodes.Where(n => n.Child == null).ToList();

            if (childlessNodes.Count > 1)
            {
                NodeModel min1 = childlessNodes[^1];
                NodeModel min2 = childlessNodes[^2];

                nodes.Add(new NodeModel { Parents = new NodeModel[] { min1, min2 }, Value = min1.Value + min2.Value, Connector = ConnectorEnum.Connector.Empty });

                min1.Child = nodes[^1];
                min1.Connector = ConnectorEnum.Connector.Left;
                min2.Child = nodes[^1];
                min2.Connector = ConnectorEnum.Connector.Right;

                nodes = CreateHuffmanTree(nodes.OrderByDescending(n => n.Value).ToList());
            }
            return nodes;
        }

        private string Encode(string binary, NodeModel node)
        {
            if (node.Connector != ConnectorEnum.Connector.Empty)
            {
                binary += ((int)node.Connector).ToString();
                binary = Encode(binary, node.Child);
            }
            return binary;
        }
    }
}
