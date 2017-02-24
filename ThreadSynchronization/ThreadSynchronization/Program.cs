using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSynchronization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Thread[] threads = new Thread[5];
            SynchronizeThreadStart start = new SynchronizeThreadStart();
            for (int i = 0; i < 5; i++)
            {
                threads[i] = new Thread(start.CountNumbersSynchronized);
                threads[i].Name = i.ToString();
            }
            foreach (var thread in threads)
            {
                thread.Start();
            }
            Console.ReadKey();
        }
    }
}
