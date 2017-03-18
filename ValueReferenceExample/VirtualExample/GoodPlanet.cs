using System;

namespace VirtualExample
{
    public class GoodPlanet : Planet
    {
        public override void DisplayPlanet()
        {
            Console.WriteLine("This is display for good planet and call base planet display");
            base.DisplayPlanet();
        }

        public override void DisplayPlanet(int count)
        {
            Console.WriteLine("This is display for good planet with parameters " +
                              "and without call base planet display");
        }
    }
}