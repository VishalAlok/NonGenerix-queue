using System;
using System.Collections;

namespace NonGenericQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Obj = new Queue();
            Obj.Enqueue("Hello1");
            Obj.Enqueue("Hello2");
            Obj.Enqueue("Hello3");
 
            foreach (string s in Obj)
            {
                Console.WriteLine(s + " ");
            }
            Obj.Dequeue();
            foreach (string s in Obj)
            {
                Console.WriteLine(s + " ");
            }
            Console.WriteLine(Convert.ToString(Obj.Peek()));
        }
    }
}
