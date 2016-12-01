using System;

namespace ThreadExample
{
    public class Cat
    {
        public string Name { get; set; }
        public static int Count = 50;
        public void SayMew()
        {
            Console.WriteLine("Cat {0} says: Fuck off, baby!", Count);
        } 
    }
}