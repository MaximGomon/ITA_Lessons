using System;

namespace FruitExample
{
    public class Apple : Fruit
    {
        public Apple() : base("Apple")
        {
        }

        public string Color { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()} color {Color}";
        }
    }
}