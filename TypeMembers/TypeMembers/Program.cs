using System;

namespace TypeMembrs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            People somePeople = new People();//People() <- call constructor
            Console.WriteLine($"Some people age: {somePeople.Age}");
            People anotherPeople = new People(23);//People(23) <- call constructor
            Console.WriteLine($"Another people age: {anotherPeople.Age}");

            People child = new People()//People() <- call constructor
            //Next code till ';' cals Object Initializer
            {
                Age = 5,
                FirstName = "Nik",
                LastName = "Valhall"
            };
            Console.WriteLine("Child: {0}", child); //<- People.ToString() will be called
            Console.WriteLine("Child year of birth: {0}", child.CalculateYearOfBirth());

            People.DisplayDescription();// <- call static method

            Console.ReadKey();
        }
    }
}
