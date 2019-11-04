using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Q = new Queue(5);
            Stack S = new Stack();

            Q.AddElements(2);
            Q.AddElements(5);
            Q.AddElements(8);
            Q.AddElements(13);
            Q.AddElements(23);

            Console.WriteLine("Items are : ");
            Q.printQueue();

            Q.deleteElements();
            Q.deleteElements();

            Console.WriteLine("Items are : ");
            Q.printQueue();
            // Console.Write("Total number of elements" + " in the Queue are : ");
            ///Console.WriteLine(Q.Count);
            ///

           
            S.Push(5);
            S.Push(10);
            S.Push(13);
            S.Push(44);
            S.Push(50);

            S.PrintStack();
            S.Peek();
            Console.WriteLine("Item popped from Stack : {0}", S.Pop());
            S.PrintStack();


            Console.ReadLine();
        }
    }
}
