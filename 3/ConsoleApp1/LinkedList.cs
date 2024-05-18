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
            
            if (this.Tail != null) {
                Node NewTail = new Node(n);
                this.Tail.Next = NewTail;

                /**/
                this.Tail = NewTail;
                if (this.MaxNode == null || n > this.MaxNode.Value)
                {
                    this.MaxNode = NewTail;
                }
                if (this.MinNode == null || n < this.MinNode.Value)
                {
                    this.MinNode = NewTail;
                }
            }
            else
            {
                this.Prepend(n);
            }

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
        private void UpdateMinMax()
        {
            this.MaxNode = null;
            this.MinNode = null;
            foreach (Node node in this.ToNodeList())
            {
                if (this.MaxNode == null || node.Value > this.MaxNode.Value)
                {
                    this.MaxNode = node;
                }
                if (this.MinNode == null || node.Value < this.MinNode.Value)
                {
                    this.MinNode = node;
                }
            }
        }
        public int Pop()
        {
            if (this.Tail == null)
            {
                throw new InvalidOperationException("Pop from empty list");
            }

            Node OldTail = this.Tail;

            
            if (this.Head == this.Tail)
            {
                this.Unqueue();

            }
            else
            {
                Node? NewTail = this.Head;
                while (NewTail?.Next?.Next != null) {
                    NewTail = NewTail.Next;
                }
                NewTail.Next = null;
                this.Tail = NewTail;

                if (OldTail.Value == this.MaxNode?.Value || OldTail.Value == this.MinNode?.Value)
                {
                    this.UpdateMinMax();
                }
            }

            return OldTail.Value;
            //
        }
        
        public int Unqueue()
        {
            if (this.Head == null)
            {
                throw new InvalidOperationException("Unqueue from empty list");
            }

            Node OldHead = this.Head;
            if (this.Head.Next == null)
            {
                /**/
                this.Head = null;
                this.Tail = null;
                this.MaxNode = null;
                this.MinNode = null;

            }
            else {
                this.Head = OldHead.Next;
                if (OldHead.Value == this.MaxNode?.Value || OldHead.Value == this.MinNode?.Value) {
                    this.UpdateMinMax();
                }
            }

            return OldHead.Value;
            //
        }

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
        