using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LinkedList
    {
        private Node? Head;

        private Node? Tail;
        private Node? MaxNode;
        private Node? MinNode;

        public LinkedList() {
            this.Head = null;
            this.Tail = null;
            this.MaxNode = null;
            this.MinNode = null;
        }
        public void Append(int n) {
            //
        }

        public void Prepend(int n)//
        {
            Node NewHead = new Node(n);
            NewHead.Next = Head;
            /**/
            if (this.Tail == null) { 
                this.Tail = NewHead;
            }
            this.Head = NewHead;
            if (this.MaxNode == null || n > this.MaxNode.Value) { 
                this.MaxNode = NewHead;
            }
            if (this.MinNode == null || n < this.MinNode.Value)
            {
                this.MinNode = NewHead;
            }



        }
        /*
        public int Pop()
        {
            //
        }

        public int Unqueue()
        {
            //
        }*/

        public IEnumerable<int> ToList() {
            Node? curr = this.Head;
            while (curr != null)
            {
                yield return curr.Value;
                curr = curr.Next;
            }
        }
        

        public bool IsCircular()
        {
            Node? fast = this.Head;
            Node? slow = this.Head;
            while (slow?.Next != null && fast?.Next?.Next != null) {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == this.Head) {
                    return true;
                }
                if (slow == fast)
                {
                    return false;
                }
            }
            return false;
            
        }
        private IEnumerable<Node> ToNodeList() {
            Node? curr = this.Head;
            while (curr != null)
            {
                yield return curr;
                curr = curr.Next;
            }
        }
        public void Sort()//
        {
            if (this.Head != null)
            {
                Node[] nodes = this.ToNodeList().OrderBy(node => node.Value).ToArray();
                for (int i = 0; i < nodes.Length - 1; i++)
                {
                    nodes[i].Next = nodes[i + 1];
                }

                nodes[nodes.Length - 1].Next = null;
                this.Head = nodes[0];

                /**/
                this.Tail = nodes[nodes.Length - 1];
                this.MaxNode = this.Tail;
                this.MinNode = this.Head;
            }

            
        }
        
        public Node? GetMaxNode()
        {
            return this.MaxNode;
        }

        public Node? GetMinNode()
        {
            return this.MinNode;
        }

        public override string ToString()
        {
            return "[" + string.Join(", ", this.ToList()) + "]";
        }
    }
}
        