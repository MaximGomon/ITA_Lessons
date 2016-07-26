using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfExample.CalcServiceReference;

namespace WcfExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new CalcServiceClient();
            Console.WriteLine(client.Sum(3, 4));
            Console.ReadKey();
        }
    }
}
