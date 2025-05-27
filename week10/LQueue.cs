namespace week10;

public class LQueue<T>
{
    private List<T> _list = new List<T>();
    public int Size
    {
        get { return _list.Count; }
    }

    public int Capacity
    {
        get { return _list.Capacity; }
    }

    public void Enqueue(T n)
    {
        // adds the value n to the back of the queue.
        _list.Add(n);
    }

    public T Dequeue()
    {
        if (_list.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        else
        {
            // removes and returns a T, the value at the front of the queue.
            T f = _list[0];
            _list.RemoveAt(0);
            return f;
        } 
        
    }
    public T Peek()
    {
            // returns the value at the front of the queue, without removing it.
           
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            else
            {
                T p = _list[0];
                return p;
                
            } 
            
    }
    public bool Contains(T n)
    {
        // returns the boolean true if the queue contains the value n.
        if (_list.Contains(n))
        {
            return true;
        }  
        else
        {
            return false;
        }
    }
    
}