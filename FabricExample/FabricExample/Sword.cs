using System;

namespace FabricExample
{
    //public class Sword : Weapon
    //{
    //    public override void Hit()
    //    {
    //        Console.WriteLine("Бьем мечом");
    //    }
    //}
    public class Sword : IWeapon
    {
        public void Hit()
        {
            Console.WriteLine("Бьем мечом");
        }
    }
}