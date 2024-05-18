

using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        for (long i = 999456789910; i < 999456789910+10; i++)
        {
            Console.WriteLine(i+" "+( new NumericalExpression(i)));
            //Console.WriteLine("Hello, World!" + (i*123456).ToString());
        }

        LinkedList list = new LinkedList();
        list.Prepend(3);
        list.Prepend(1);
        list.Prepend(1);
        list.Prepend(2);
        list.Prepend(500);
        list.Prepend(2);
        Console.WriteLine(list.ToString());
        list.Sort();
        Console.WriteLine(list.ToString());
    }
}