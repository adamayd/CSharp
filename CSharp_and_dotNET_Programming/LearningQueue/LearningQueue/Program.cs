using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);

            //foreach (var queue in myQueue)
            //{
            //    Console.WriteLine(queue);
            //}

            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Peek());
            Console.WriteLine(myQueue.Peek());
        }
    }
}
