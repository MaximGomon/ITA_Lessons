using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            IAggregate<int> collection = new CustomCollection<int>();
            collection[0] = 4;
            collection[1] = 12;
            collection[2] = 423;
            collection[3] = 62;


            IIterator iterator = collection.GetIterator();

            Console.WriteLine(iterator.First());

            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.Next());
            }
            Console.ReadKey();
        }
    }
}
