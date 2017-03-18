using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Planet p = new Planet();
            p.DisplayPlanet();
            Console.ReadLine();
            p.DisplayPlanet(3);
            Console.ReadLine();

            Planet good = new GoodPlanet();
            good.DisplayPlanet();
            Console.ReadLine();
            good.DisplayPlanet(1);
            Console.ReadLine();
        }
    }
}
