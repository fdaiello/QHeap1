using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace QHeap1
{
    class Solution
    {
        class Heap
        {
            private readonly SortedList<int, int> list = new SortedList<int, int>();
            public readonly StringBuilder outBuffer = new StringBuilder();

            public void Add(int v)
            {
                list.Add(v,v);
            }
            public void Delete(int v)
            {
                list.Remove(v);
            }
            public void PrintMin()
            {
                outBuffer.AppendLine(list.ElementAt(0).Key.ToString());
            }
        }

        static void Main(string[] args)
        {
            Heap heap = new Heap();

            int q = Int32.Parse(Console.ReadLine());

            for ( int i=0; i < q; i++)
            {
                string[] commands = Console.ReadLine().Split(' ');
                switch (commands[0])
                {
                    case "1":
                        heap.Add(Int32.Parse(commands[1]));
                        break;
                    case "2":
                        heap.Delete(Int32.Parse(commands[1]));
                        break;
                    case "3":
                        heap.PrintMin();
                        break;
                }
            }

            Console.WriteLine(heap.outBuffer);
        }
    }
}
