using System;
using MyFIrstApplication;

namespace FIrstApplication
{
    public class Program
    {
        private const int MyConstant = 10;

        public static void Main()
        {
            Console.WriteLine("Hello");
            Console.WriteLine(MyConstant);

            string userInput = "blabla";//Console.ReadLine();
            double doubleNumber = 123.22367;

            Console.WriteLine($"You entered:\t{userInput}");
            //Console.WriteLine("You entered: " + userInput);
            //Console.WriteLine("You entered: {0}", userInput);
            //Console.WriteLine(string.Format("You entered: {0}", userInput));
            Console.WriteLine($"{doubleNumber:.##}");

            bool isTrue = false;

            int[] myArray = new int[4];
            Console.WriteLine(myArray);
            Console.WriteLine(isTrue);

            MyFirstClass variable = new MyFirstClass();
            variable.Number = 3;
            variable.Text = "MyText";

            Console.WriteLine(variable);

            variable.DisplayText();
            MyFirstClass.DisplayStaticText();

            int number = 12;
            DisplayNumber(number);
            Console.WriteLine($"Last value: {number}");
            Console.WriteLine(new String('*', 60));
            DisplayNumber(variable);
            Console.WriteLine($"Last value: {variable.Number}");

            Console.ReadKey();
        }

        public static void DisplayNumber(int number)
        {
            Console.WriteLine($"Start value: {number}");
            number++;
            Console.WriteLine($"Value after change: {number}");
        }

        public static void DisplayNumber(MyFirstClass source)
        {
            source = new MyFirstClass();
            Console.WriteLine($"Start value: {source.Number}");
            source.Number++;
            Console.WriteLine($"Value after change: {source.Number}");
        }
    }
}
