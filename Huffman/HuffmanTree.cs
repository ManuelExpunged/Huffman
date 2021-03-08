using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huffman
{
    public class HuffmanTree
    {
        private readonly char[] letters;
        private readonly Dictionary<char, int> countedLetters = new Dictionary<char, int>();
        private Node root;

        public HuffmanTree(string src)
        {
            letters = src.ToCharArray();
            CountLetters();
            BuildTree();
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
                    Letter = null,
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

        public List<string> Encode()
        {
            List<string> encodedSrc = new List<string>();
            encodedSrc.AddRange(letters.Select(c => string.Join(string.Empty, root.Traverse(c, new List<bool>()).Select(b => b ? "1" : "0"))));
            return encodedSrc;
        }
    }

    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public char? Letter { get; set; }
        public int Count { get; set; }

        public List<bool> Traverse(char? c, List<bool> data)
        {
            if (Left == null && Right == null)
            {
                return (bool)c?.Equals(Letter) ? data : null;
            }
            else
            {
                List<bool> left = null;
                List<bool> right = null;

                if (Left != null)
                {
                    List<bool> leftPath = new List<bool>(data);
                    leftPath.Add(false);
                    left = Left.Traverse(c, leftPath);
                }

                if (Right != null)
                {
                    List<bool> rightPath = new List<bool>(data);
                    rightPath.Add(true);
                    right = Right.Traverse(c, rightPath);
                }

                return left ?? right;
            }
        }
    }
}
