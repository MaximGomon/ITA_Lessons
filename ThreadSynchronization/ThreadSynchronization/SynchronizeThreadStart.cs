using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSynchronization
{
    [Synchronization]
    public class SynchronizeThreadStart : ContextBoundObject
    {
        public void CountNumbersSynchronized()
        {
            if (Thread.CurrentThread.Name == "2")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Thread #2 ends with error");
                Console.ForegroundColor = ConsoleColor.Green;
                return;
            }
            Console.WriteLine($"Thread #{Thread.CurrentThread.Name} start counting");
            Console.WriteLine("Numbers:");
            for (int i = 0; i < 5; i++)
            {
                if (i < 4)
                    Console.Write(i + ", ");
                else
                    Console.WriteLine(i);
                Random r = new Random();
                Thread.Sleep(500 * r.Next(5));
            }
            Console.WriteLine($"Thread #{Thread.CurrentThread.Name} end counting");
            Console.WriteLine(new string('-', 30));
        }
    }
}
