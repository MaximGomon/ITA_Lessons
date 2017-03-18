namespace FabricExample.Factories
{
    public class DiggHeroFactory : HeroFactory
    {
        public override IMovement CreateMovement()
        {
            return new Digg();
        }

        public override IWeapon CreateWeapon()
        {
            return new Lopata();
        }
    }
}