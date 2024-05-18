namespace ConsoleApp1
{
    internal class Node
    {
        public int Value { get; }
        public Node? Next { get; set; }

        public Node(int Value)
        {
            this.Value = Value;
            this.Next = null;
        }
    }
}
