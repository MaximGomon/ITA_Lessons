using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public class Program
    {
        public delegate int OperationDelegate(int a, int b);

        delegate void EventClick(object sender, EventArgs args);

        static void Main(string[] args)
        {
            OperationDelegate operation = Sum;

            int result = operation(4, 7);

            Calc c = new Calc(Minus);
            Calc c1 = new Calc(Sum);

            //Console.WriteLine(result);
            //operation = Minus;
            //result = operation(8, 2);

            //Console.WriteLine(result);
            Console.ReadKey();
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Minus(int a, int b)
        {
            return a - b;
        }
    }
}
