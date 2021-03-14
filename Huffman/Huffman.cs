using System;
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
            HuffmanTree huffmanTree = new HuffmanTree(InputBox.Text);
            BinaryBox.Text = string.Join(" ", huffmanTree.BinaryRepresentation);
            TreeBox.Text = huffmanTree.TreeRepresentation;
        }
    }
}
