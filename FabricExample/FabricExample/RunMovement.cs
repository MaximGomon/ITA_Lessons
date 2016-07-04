using System;

namespace FabricExample
{
    //public class RunMovement : Movement
    //{
    //    public override void Move()
    //    {
    //        Console.WriteLine("Бежим");
    //    }
    //}
    public class RunMovement : IMovement
    {
        public void Move()
        {
            Console.WriteLine("Бежим");
        }
    }
}