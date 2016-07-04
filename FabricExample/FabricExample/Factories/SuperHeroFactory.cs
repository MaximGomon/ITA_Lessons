namespace FabricExample.Factories
{
    public class SuperHeroFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Arbalet();
        }
    }
}