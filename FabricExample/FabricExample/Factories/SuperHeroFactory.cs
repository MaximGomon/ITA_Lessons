namespace FabricExample.Factories
{
    public class SuperHeroFactory : HeroFactory
    {
        public override IMovement CreateMovement()
        {
            return new RunMovement();
        }

        public override IWeapon CreateWeapon()
        {
            return new Arbalet();
        }
    }
}