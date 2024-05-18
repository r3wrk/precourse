using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Node
    {
        public int Value { get; }
        public Node? Next { get; set; }

        public Node(int Value) {
            this.Value = Value;
            this.Next = null;
        }
    }
}
