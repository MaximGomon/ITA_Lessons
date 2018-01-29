using System;
using System.Collections.Generic;
using FabricExample.Factories;

namespace FabricExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var heroes = new List<Hero>()
            {
                new Hero(new ElfFactory()),
                new Hero(new VoinFactory()),
                new Hero(new SuperHeroFactory()),
                new Hero(new DiggHeroFactory())
            };

            foreach (var hero in heroes)
            {
                hero.Hit();
                hero.Run();
            }
            Console.ReadLine();
        }
    }
}
