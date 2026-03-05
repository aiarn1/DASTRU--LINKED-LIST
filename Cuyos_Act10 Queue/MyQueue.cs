using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuyos_Act10_Queue
{
     class MyQueue
    {
        // LinkList implementation of Queue
        private Queue<int> queue = new Queue<int>();

        // Enqueue method to add an element 
        public void Enqueue(int value)
        {
            queue.Enqueue(value);
            Console.WriteLine("Added: " + value);
        }
        // Dequeue method to remove an element
        public void Dequeue()
        {
            if (queue.Count == 0)
                throw new InvalidOperationException("Queue is empty.");

            Console.WriteLine("Removed: " + queue.Dequeue());
        }
        // Display method to show all elements in the queue
        public void Display()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }
            foreach (var item in queue)
                Console.Write("Updated Queue: " + item + " ");
            Console.WriteLine();
        }
    }
}

