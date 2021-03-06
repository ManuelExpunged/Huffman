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
                        binaries.Add(EncodeString(string.Empty, node));
                    }
                }
            }

            BinaryBox.Text = string.Join(" ", binaries);
            //TreeBox.Text = CreateHuffmanTreeRepresentation(string.Empty, huffman[0]);
        }

        private string CreateHuffmanTreeRepresentation(string tree, NodeModel node)
        {
            if (node.Parents != null)
            {
                tree += "*";
            }
            else
            {
                tree += node.Key;
            }
            
            if (node.Parents != null)
            {
                foreach (NodeModel parentNode in node.Parents)
                {
                    tree = CreateHuffmanTreeRepresentation(tree, parentNode);
                }
            }

            return tree;
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

        private string EncodeString(string binary, NodeModel node)
        {
            if (node.Connector != ConnectorEnum.Connector.Empty)
            {
                binary += ((int)node.Connector).ToString();
                binary = EncodeString(binary, node.Child);
            }
            return binary;
        }
    }
}
