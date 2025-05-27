using week10;

namespace TestWeek10;
using NUnit.Framework;
using week10;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestEnqueue()
    {
        var queue = new LQueue<int>();
        queue.Enqueue(5);
        queue.Enqueue(10);
        Assert.AreEqual(2,queue.Size);
    }
    
    [Test]
    public void TestDequeue()
    {
        var queue = new LQueue<int>();
        queue.Enqueue(5);
        queue.Enqueue(10);
        Assert.AreEqual(5,queue.Dequeue());
        Assert.AreEqual(1,queue.Size);
        Assert.AreEqual(10, queue.Dequeue());
        Assert.Throws(typeof(InvalidOperationException), () => queue.Dequeue());
    }
    [Test]
    public void TestPeek()
    {
        var queue = new LQueue<int>();
        queue.Enqueue(5);
        queue.Enqueue(10);
        Assert.That(queue.Peek(), Is.EqualTo(5));
        Assert.AreEqual(2,queue.Size);
        Assert.AreEqual(5,queue.Peek());
        Assert.Throws(typeof(InvalidOperationException), () => new LQueue<int>().Peek());
        
    }
    [Test]
    public void TestContains()
    {
        var queue = new LQueue<int>();
        queue.Enqueue(5);
        queue.Enqueue(10);
        Assert.IsTrue(queue.Contains(5));
        Assert.IsTrue(queue.Contains(10));
        Assert.IsFalse(queue.Contains(15));
        Assert.IsFalse(new LQueue<int>().Contains(5));
    }
}