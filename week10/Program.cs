namespace week10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Performance.EnqueueTest();
        Performance.PerformanceTestDequeue();
        Performance.PerformanceTestPeek();
        Performance.PerformanceTestContains();
    }
}