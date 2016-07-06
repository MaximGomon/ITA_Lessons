namespace FabricExample.Factories
{
    public class VoinFactory : HeroFactory//IHeroFactory
    {
        public override IMovement CreateMovement()
        {
            return new RunMovement();
        }

        public override IWeapon CreateWeapon()
        {
            return new Sword();
        }

        //public Movement CreateMovement()
        //{
        //    return new RunMovement();
        //}

        //public Weapon CreateWeapon()
        //{
        //    return new Sword();
        //}
    }
}