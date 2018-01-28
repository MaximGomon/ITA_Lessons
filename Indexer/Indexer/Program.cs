using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input array elements count: ");
            int itemsCount = int.Parse(Console.ReadLine());
            //Fruits[] array = new Fruits[itemsCount];
            var container = new GenericContainer<Fruits>(itemsCount);

            for (int i = 0; i < container.Count; i++)
            {
                Console.Write("Enter 1-2 for create or \'D\' for display: ");
                var userInput = Console.ReadKey();
                Console.WriteLine();
                switch (userInput.Key)
                {
                    //Ctrl+R+R - Rename - F2
                    case ConsoleKey.D1:
                        //array[i] = new Apple();
                        container.AddElement(new Apple());
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Add {nameof(Apple)}");
                        Console.ResetColor();
                        break;
                    case ConsoleKey.D2:
                        container.AddElement(new Cucumber());
                        //array[i] = new Cucumber();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Add {nameof(Cucumber)}");
                        Console.ResetColor();
                        break;
                    case ConsoleKey.D:
                        //DisplayGeneric(container);
                        DisplayContainer(container);
                        i--;
                        break;
                    default:
                        i--;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Entered wrong value");
                        Console.ResetColor();
                        break;
                }
            }

            DisplayGeneric(container);

            Console.WriteLine(container[2]);

            Console.Write("Press any key to exit...");
            Console.ReadLine();
        }

        private static void DisplayContainer<T>(GenericContainer<T> array) where T : Fruits
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('*', 40));
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine(new string('*', 40));
            Console.ResetColor();
        }

        private static void DisplayGeneric<T>(GenericContainer<T> array) where T : Fruits
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('*', 40));
            foreach (var fruitse in array.GetAllElements())
            {
                Console.WriteLine(fruitse);
            }
            Console.WriteLine(new string('*', 40));
            Console.ResetColor();
        }

        private static void DisplayArray(Fruits[] array)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('*', 40));
            foreach (var fruitse in array)
            {
                Console.WriteLine(fruitse);
            }
            Console.WriteLine(new string('*', 40));
            Console.ResetColor();
        }
    }
}
