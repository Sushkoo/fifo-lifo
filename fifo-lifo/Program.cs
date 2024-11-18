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


        FIFO queue = new FIFO(5);

        queue.Push(10);
        queue.Push(20);
        queue.Push(30);

        Console.WriteLine("FIFO:");
        Console.WriteLine($"Pop element: {queue.Pop()}");

        Console.WriteLine($"Queue length: {queue.Length()}");
        Console.WriteLine($"Queue size: {queue.GetSize()}");

        queue.Clear();
        Console.WriteLine($"Queue length after clear: {queue.Length()}");


        USet halmaz = new(5);
        halmaz.Push("Piroska");
        halmaz.Push("Géza");
        halmaz.Push("István");
        halmaz.Push("Piroska");
        halmaz.Push("Péter");
        //halmaz.Push("Ádám");
        Console.WriteLine(halmaz.ToString());
        halmaz.Remove("István");
        Console.WriteLine(halmaz.ToString());
    }


    

}



class USet
{
    // amiben tároljuk

    private String[] array;
    private int length = 0;


    public override string? ToString()
    {
        String result = "";
        for (int i = 0; i < length; i++)
        {
            result += array[i] + ";";
        }
        return result;
    }

    public USet() : this(50)
    {
    }


    public USet(int capacity)
    {
        array = new String[capacity];
    }

    public void Push(String name)
    {
        if (length == array.Length)
        {
            throw new Exception("Betelt a FIFO! Queue overflow!");
        }
        for (int index = 0; index < length; index++)
        {
            if (array[index] == name)
            {
                return;
            }
        }
        array[length] = name;
        ++length;
    }


    public void Remove(String name)
    {
        if (length == 0)
        {
            throw new Exception($"Üres halmazból nem lehet törölni a {name} értéket!");
        }

        for (int index = 0; index < length; index++)
        {
            if (array[index] == name)
            {
                array[index] = array[length];
                return;
            }
        }
        throw new Exception($"A {name} érték nem szerepel a halmazban!");
    }



    public void Clear()
    {
        length = 0;
    }


    public int Length => length;

    public int Capacity => array.Length;



}