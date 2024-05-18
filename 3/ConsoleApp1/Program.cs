

using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        for (long i = 999456789910; i < 999456789910 + 10; i++)
        {
            Console.WriteLine(i + " " + (new NumericalExpression(i)));

        }
        Console.WriteLine(NumericalExpression.SumLetters(1000) == 18455);

        LinkedList list = new LinkedList();
        list.Prepend(3);
        list.Prepend(1);
        list.Prepend(1);
        list.Prepend(2);
        list.Prepend(500);
        list.Prepend(2);
        Console.WriteLine(list);
        Console.WriteLine(list.GetMinNode().Value + " " + list.GetMaxNode().Value);
        list.Sort();
        Console.WriteLine(list);
        Console.WriteLine(list.GetMinNode().Value + " " + list.GetMaxNode().Value);
        list.Pop();
        Console.WriteLine(list);
        Console.WriteLine(list.GetMinNode().Value + " " + list.GetMaxNode().Value);
        list.Unqueue();
        Console.WriteLine(list);
        Console.WriteLine(list.GetMinNode().Value + " " + list.GetMaxNode().Value);
        list.Unqueue();
        Console.WriteLine(list);
        Console.WriteLine(list.GetMinNode().Value + " " + list.GetMaxNode().Value);
        list.Prepend(700);
        Console.WriteLine(list);
        Console.WriteLine(list.GetMinNode().Value + " " + list.GetMaxNode().Value);
        list.Append(-1);
        list.Append(7);
        Console.WriteLine(list);
        Console.WriteLine(list.GetMinNode().Value + " " + list.GetMaxNode().Value);

    }
}