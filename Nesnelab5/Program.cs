using Nesnelab5;


namespace Nesnelab5;

public class Program
{
    public static void Main()
    {
        /*
        var act01 = ResultSets.Action1();
        Console.WriteLine($"{act01.status,-5}" +
         $"{act01.message,-5}");

        var act02 = ResultSets.Action2();
        Console.WriteLine($"{act02.status,-5}" +
         $"{act02.message,-5}");

        var act03 = ResultSets.Action3();
        Console.WriteLine($"{act03.status,-5}" +
         $"{act03.message,-5}");


        var act04 = ResultSets.Action4();
        Console.WriteLine($"{act04.status,-5}" +
         $"{act04.message,-5}");
        */


        MaxHeap heap = new MaxHeap();
        //MinHeap heap = new MinHeap();

        heap.Insert(5);
        heap.Insert(6); 
        heap.Insert(7);
        heap.Insert(8); 
        heap.Insert(2);
        heap.Insert(1);

        Console.WriteLine($"{heap.Extract()}");
        Console.WriteLine($"{heap.Extract()}");
        Console.WriteLine($"{heap.Extract()}");
        Console.WriteLine($"{heap.Extract()}");
        Console.WriteLine($"{heap.Extract()}");
        Console.WriteLine($"{heap.Extract()}");




    }

}