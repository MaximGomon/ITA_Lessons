using System;

namespace FabricExample
{
    //public class Arbalet : Weapon
    //{
    //    public override void Hit()
    //    {
    //        Console.WriteLine("Стреляем из арбалета");
    //    }
    //}
    public class Arbalet : IWeapon
    {
        public void Hit()
        {
            Console.WriteLine("Стреляем из арбалета");
        }
    }
}