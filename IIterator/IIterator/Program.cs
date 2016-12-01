using System;
namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            IAggregate<Car> carCollection = new MyAggregate<Car>();
            carCollection.Add(new Car { Model = "Lancer"});
            carCollection.Add(new Car { Model = "Impreza" });
            carCollection.Add(new Car { Model = "Elysee" });
            carCollection.Add(new Car { Model = "DS4" });
            carCollection.Add(new Car { Model = "Prado" });

            IIterate<Car> carIterator = carCollection.CreateIterator();

            Console.WriteLine($"First item is {carIterator.First()}");

            while (!carIterator.IsDone())
            {
                Console.WriteLine(carIterator.CurrentItem());
                carIterator.MoveNext();
            }

            Console.WriteLine(carCollection[2]);
            Console.ReadKey();
        }
    }
}
