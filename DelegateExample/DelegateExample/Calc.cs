using System;

namespace DelegateExample
{
    public class Calc
    {
        public Calc(Program.OperationDelegate del)
        {
            Console.WriteLine(del(4, 6));
        }
    }
}