using System;

namespace MyFIrstApplication
{
    public class MyFirstClass
    {
        public void DisplayText()
        {
            System.Console.WriteLine("I am text!");
        }

        public static void DisplayStaticText()
        {
            Console.WriteLine("Static text");
        }

        public int Number { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return $"{Number} {Text}";
        }
    }
}