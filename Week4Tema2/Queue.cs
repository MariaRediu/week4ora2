using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Tema2
{
    public class Queue
    {
        private int[] elemente;
        private int first;
        private int last;
        private int max;


       //public virtual int Count { get; }
        public Queue(int size)
        {
            elemente = new int[size];
            first = 0;
            last = -1;
            max = size;
        }


        public void AddElements(int item)
        {
            if (last == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                elemente[++last] = item;
            }
        }

        public int deleteElements()
        {
            if (first == last + 1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine("deleted element is: " + elemente[first]);
                return elemente[first++];
            }
        }

        public void printQueue()
        {
            if (first == last + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (int i = first; i <= last; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + elemente[i]);
                }
            }
        }
    }
}
