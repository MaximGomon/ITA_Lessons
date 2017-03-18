using System;

namespace VirtualExample
{
    public class Planet
    {
        public virtual void DisplayPlanet()
        {
            Console.WriteLine("This is base virtual display planet without parameters");
        }

        public virtual void DisplayPlanet(int count)
        {
            Console.WriteLine("This is base virtual display planet with parameters count = {0}", count);
        }
    }
}