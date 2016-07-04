using System;

namespace FabricExample
{
    //public class FlyMovement : Movement
    //{
    //    public override void Move()
    //    {
    //        Console.WriteLine("Летим");
    //    }
    //}
    public class FlyMovement : IMovement
    {
        public void Move()
        {
            Console.WriteLine("Летим");
        }
    }
}