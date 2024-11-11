using fifo_lifo;

internal class Program
{
    private static void Main(string[] args)
    {
        LIFO verem = new LIFO(3);
        verem.Push(123.56);
        verem.Push(-12.56);
        verem.Push(3.6);
        verem.Pop(0);

        Console.WriteLine(verem.Length());
    }


}