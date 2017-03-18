using System;
using FabricExample.Factories;

namespace FabricExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();

            Hero voin = new Hero(new VoinFactory());
            voin.Hit();
            voin.Run();

            var superVoin = new Hero(new SuperHeroFactory());
            superVoin.Hit();
            superVoin.Run();

            var diggVoin = new Hero(new DiggHeroFactory());
            diggVoin.Hit();
            diggVoin.Run();

            Console.ReadLine();
        }
    }
}
