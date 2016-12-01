using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExample
{
    class Programs
    {
        //static void Main(string[] args)
        //{
        //    int count = 50;
        //    for(int i = 0; i < count; i ++)
        //    {
        //        Thread th = new Thread(CreateCat);
        //       // Thread.Sleep(i);
        //        th.Start();
        //    }
        //    Console.WriteLine("Hello");
        //    Console.ReadKey();
        //}

        static void CreateCat()
        {
            int a = 0;
            a = GetA(a);
            Cat c = new Cat
            {
                Name = "Cat" + a
            };
            Cat.Count--;
            Thread.Sleep(1000);
            c.SayMew();
        }

        static int GetA(int a)
        {
            a++;
            return a;
        }
    }
}
