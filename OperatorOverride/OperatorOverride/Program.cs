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
            //int i = 9;
            //object a = i;
            //i = 12;
            //Console.WriteLine($"{i}, {(int)a}");
            //Console.ReadLine();

            //DisplayArray(new string[] {"item1", "item2"});
            //DisplayArray("myFirstItem", "mySecondItem");

            string[] myArray = new string[100];
            for (int i = 0; i < 100; i++)
            {
                myArray[i] = "Hello";
            }
            Console.WriteLine(string);
            bool item = Object.ReferenceEquals(myArray[0], myArray[1]);


            var q = Chain.Queue;

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
            
            Console.WriteLine(chain++);

            Console.WriteLine(chain);

            Console.WriteLine(queue);
            Console.WriteLine(secondQueue);
            Console.WriteLine(secondChain);

            Console.ReadKey();
        }
        

        static void DisplayArray(params string[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static IEnumerable<string> GetItems()
        {
            yield return "A";
            yield break;
            yield return "A";
            yield return "A";
        }
    }
}
