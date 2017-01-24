using System;

namespace FruitExample
{
    class Program
    {
        public static void Main()
        {
            int number = 0;
            while (true)
            {
                Console.Write("How muth fruit you want create? ");
                
                bool isNumber = int.TryParse(Console.ReadLine(), out number);
                if (isNumber)
                {
                    break;
                }
                else
                {
                    Console.Beep();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter only digit");
                    Console.ResetColor();
                }
            }
            Fruit[] fruitMass = new Fruit[number];

            Console.WriteLine("Please create some fruits!");
            Console.WriteLine("For create mango, press 1!");
            Console.WriteLine("For create apple, press 2!");

            for (int i = 0; i < fruitMass.Length; i++)
            {
                Console.Write("Please enter your choise: ");
                string userInput = Console.ReadLine();
                int userNumber = 0;
                //Convert.ToInt32(userInput);
                //int.Parse(userInput);

                bool isNumber = int.TryParse(userInput, out userNumber);

                if (isNumber)
                {
                    if (userNumber == 1)
                    {
                        //create mango
                        Mango m = new Mango();
                        m.Size = 2;
                        fruitMass[i] = m;
                        Console.WriteLine($"Fruit \'{m}\' created");
                        //Console.WriteLine("Fruit {0} created", m);
                    }
                    else if (userNumber == 2)
                    {
                        //create apple
                        Apple a = new Apple();
                        a.Color = "Green";
                        fruitMass[i] = a;
                        Console.WriteLine($"Fruit \'{a}\' created");
                    }
                }
                else
                {
                    Console.Beep();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter only digit");
                    Console.ResetColor();
                    //continue;
                }

                //Console.WriteLine("Press any key to continue or \'n\' to exit?");
                //ConsoleKeyInfo enteredKey = Console.ReadKey();
                //ConsoleKey key = enteredKey.Key;
                //Console.WriteLine();

                //if (key == ConsoleKey.N)
                //{
                //    break;
                //}
            }

            Console.WriteLine();
            Console.WriteLine("You finish create fruits!");
            Console.WriteLine("Created fruits:");
            for (int i = 0; i < fruitMass.Length; i++)
            {
                Console.WriteLine(fruitMass[i]);
            }
            Console.ReadKey();
        }
    }
}
