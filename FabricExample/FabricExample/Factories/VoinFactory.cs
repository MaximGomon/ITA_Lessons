namespace FabricExample.Factories
{
    public class VoinFactory : HeroFactory//IHeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
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