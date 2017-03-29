using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Chain chain = new Chain
            {
                CountOfElements = 4
            };
            MyQueue queue = chain;

            MyQueue secondQueue = new MyQueue
            {
                ElementCount = 12
            };

            Chain secondChain = secondQueue;

            if (secondChain == null)
            {
                
            }
            Console.WriteLine(chain++);

            Console.WriteLine(chain);

            Console.WriteLine(queue);
            Console.WriteLine(secondQueue);
            Console.WriteLine(secondChain);

            Console.ReadKey();
        }
    }
}
