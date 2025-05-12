using System;
using System.Collections.Generic;
class Program
{

    static void Main()
    {

        Queue<string> queue = new Queue<string>();

        // Enqueue
        queue.Enqueue("A");
        queue.Enqueue("B");
        queue.Enqueue("C");
        Console.WriteLine("Queue: " + string.Join(", ", queue));

        // Dequeue
        string first = queue.Dequeue();
        Console.WriteLine("Dequeued: " + first);
        Console.WriteLine("Queue now: " + string.Join(", ", queue));

        // Peek
        Console.WriteLine("Front: " + queue.Peek());
    }

}

