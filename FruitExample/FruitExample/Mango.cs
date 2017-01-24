using System;

namespace FruitExample
{
    public class Mango : Fruit
    {
        public int Size { get; set; }

        public Mango() : base("Mango")
        {
        }

        public override string ToString()
        {
            return $"{base.ToString()} size: {Size}";
        }
    }
}