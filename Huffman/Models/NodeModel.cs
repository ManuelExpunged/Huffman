using System;
using System.Collections.Generic;
using System.Text;

namespace Huffman.Models
{
    class NodeModel
    {
        public NodeModel[] Parents { get; set; }
        public NodeModel Child { get; set; }
        public char Key { get; set; }
        public int Value { get; set; }
        public ConnectorEnum.Connector Connector { get; set; }
    }
}
