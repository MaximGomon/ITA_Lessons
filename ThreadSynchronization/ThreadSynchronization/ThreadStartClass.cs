using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSynchronization
{
    public class ThreadStartClass
    {
        private readonly object _synchObject = new object();
        public void CountNumbers()
        {
            lock (_synchObject)
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

        public void CountNumbersMonitor()
        {
            Monitor.Enter(_synchObject);
            try
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
            finally
            {
                Monitor.Exit(_synchObject);
            }
        }

        
    }
}
