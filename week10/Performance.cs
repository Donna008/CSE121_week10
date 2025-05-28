namespace week10;
using System.Diagnostics;

public class Performance
{
    // public static void EnqueueTest()
    // {
    //     
    //     Stopwatch sw = new Stopwatch();
    //
    //     Console.WriteLine("Performance Test Enqueue Started");
    //     sw.Start();
    //     var queue = new LQueue<int>();
    //     
    //     for (int i = 0; i < 100000; i++)
    //     {
    //         queue.Enqueue(i);
    //     }
    //     sw.Stop();
    //     Console.WriteLine($"Enqueue Time: {sw.ElapsedMilliseconds} ms");
    // }
//     public static void PerformanceTestDequeue()
//     {
//         Stopwatch sw = new Stopwatch();
//   
//         Console.WriteLine("Performance Test Dequeue Started");
//         sw.Start();
//         var queue = new LQueue<int>();
//         queue.Enqueue(100);
//         queue.Enqueue(100);
//         queue.Enqueue(100);
//         queue.Enqueue(100);
//         queue.Enqueue(100);
//         
//         for (int i = 0; i < 5; i++)
//         {
//             queue.Dequeue();
//         }
//         
//         sw.Stop();
//         Console.WriteLine($"Dequeue Time: {sw.ElapsedMilliseconds} ms");
//     }
//     
    // public static void PerformanceTestDequeue()
    // {
    //     Stopwatch sw = new Stopwatch();
    //
    //     Console.WriteLine("Performance Test Dequeue Started");
    //     sw.Start();
    //     var queue = new LQueue<int>();
    //     for (int i = 0; i < 100000; i++)
    //     {
    //         queue.Enqueue(i);
    //     }
    //
    //     for (int i = 0; i < 100000; i++)
    //     {
    //         queue.Dequeue();
    //     }
    //
    //     sw.Stop();
    //     Console.WriteLine($"Dequeue Time: {sw.ElapsedMilliseconds} ms");
    // }

    public static void PerformanceTestPeek()
    {
        var sizes = new int[] { 100, 1000, 10000, 100000 };
        var queue = new LQueue<int>();
        foreach (int size in sizes)
        {
            while (queue.Size < size)
            {
                queue.Enqueue(queue.Size);
            }

            Stopwatch sw = new Stopwatch();
            var f = queue.Peek();
            sw.Stop();
            Console.WriteLine($"Size: {queue.Size}, Capacity: {queue.Capacity}, Peek Time: {sw.ElapsedTicks} ticks");
        }
// Finding:So the finding is that even with array resizing, the time performance doesn’t change, it’s always O(1).
    }



    // public static void PerformanceTestContains()
    // {
    //     Stopwatch sw = new Stopwatch();
    //
    //     Console.WriteLine("Performance Test Contains Started");
    //     sw.Start();
    //     var queue = new LQueue<int>();
    //     Console.WriteLine($"Initial Capacity: {queue.Capacity}");
    //     for (int i = 0; i < 100000; i++)
    //     {
    //         queue.Enqueue(i);
    //     }
    //
    //     for (int i = 0; i < 100000; i++)
    //     {
    //         queue.Contains(i);
    //     }
    //
    //     sw.Stop();
    //     Console.WriteLine($"Final Capacity: {queue.Capacity}");
    //     Console.WriteLine($"Final Size: {queue.Size}");
    //     Console.WriteLine($"Contains Time: {sw.ElapsedMilliseconds} ms");
    // }
}