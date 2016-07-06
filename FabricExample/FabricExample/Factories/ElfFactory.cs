namespace FabricExample.Factories
{
    public class ElfFactory : HeroFactory//IHeroFactory
    {
        public override IMovement CreateMovement()
        {
            return new FlyMovement();
        }

        public override IWeapon CreateWeapon()
        {
            return new Arbalet();
        }

        //public Movement CreateMovement()
        //{
        //    return new FlyMovement();
        //}

        //public Weapon CreateWeapon()
        //{
        //    return new Arbalet();
        //}
    }
}