namespace FabricExample.Factories
{
    public class ElfFactory : HeroFactory//IHeroFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override Weapon CreateWeapon()
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