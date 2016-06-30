namespace FabricExample.Factories
{
    public abstract class HeroFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
    }

    //public interface IHeroFactory
    //{
    //    Movement CreateMovement();
    //    Weapon CreateWeapon();
    //}

}