using System;
using System.Collections.Generic;
using System.Linq;

namespace Huffman
{
    public class HuffmanTree
    {
        private readonly char[] letters;
        private readonly Dictionary<char, int> countedLetters = new Dictionary<char, int>();
        private Node root;

        public List<string> BinaryRepresentation { get; private set; } = new List<string>();
        public string TreeRepresentation { get; private set; }

        public HuffmanTree(string src)
        {
            letters = src.ToCharArray();
            CountLetters();
            BuildTree();
            BuildBinary();
            TreeRepresentation = root.MapToString(root, string.Empty, string.Empty, false);
        }

        private void CountLetters()
        {
            foreach (char c in letters)
            {
                if (!countedLetters.ContainsKey(c))
                {
                    countedLetters.Add(c, 1);
                }
                else
                {
                    countedLetters[c]++;
                }
            }
        }

        private void BuildTree()
        {
            List<Node> nodes = countedLetters
                .Select(c => new Node { Letter = c.Key, Count = c.Value })
                .ToList();

            while (nodes.Count > 1)
            {
                List<Node> sortedNodes = nodes.OrderBy(n => n.Count).ToList();

                Node parent = new Node()
                {
                    Letter = '*',
                    Count = sortedNodes[0].Count + sortedNodes[1].Count,
                    Left = sortedNodes[0],
                    Right = sortedNodes[1]
                };

                nodes.Remove(sortedNodes[0]);
                nodes.Remove(sortedNodes[1]);
                nodes.Add(parent);
            }

            root = nodes.FirstOrDefault();
        }

        private void BuildBinary() => BinaryRepresentation.AddRange(letters.Select(c => string.Join(string.Empty, root.MapToBinary(c, new List<bool>()).Select(b => b ? "1" : "0"))));
    }

    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public char Letter { get; set; }
        public int Count { get; set; }

        public List<bool> MapToBinary(char c, List<bool> data)
        {
            if (Left == null && Right == null)
            {
                return (bool)c.Equals(Letter) ? data : null;
            }
            else
            {
                List<bool> left = null;
                List<bool> right = null;

                if (Left != null)
                {
                    List<bool> leftPath = new List<bool>(data);
                    leftPath.Add(false);
                    left = Left.MapToBinary(c, leftPath);
                }

                if (Right != null)
                {
                    List<bool> rightPath = new List<bool>(data);
                    rightPath.Add(true);
                    right = Right.MapToBinary(c, rightPath);
                }

                return left ?? right;
            }
        }

        public string MapToString(Node node, string output, string indentation, bool hasNodeBelow)
        {
            output += BuildNodeString(indentation, node.Letter, node.Count);
            indentation += !hasNodeBelow ? "\t" : "|\t";

            if (node.Right != null)
            {
                output = MapToString(node.Right, output, indentation, true);
            }

            if (node.Left != null)
            {
                output = MapToString(node.Left, output, indentation, false);
            }

            return output;
        }

        private string BuildNodeString(string indentation, char letter, int count) => $"{indentation}+--- {letter} [{count}]\r\n";
    }
}
