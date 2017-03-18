namespace FabricExample.Factories
{
    public abstract class HeroFactory
    {
        public abstract IMovement CreateMovement();
        public abstract IWeapon CreateWeapon();
    }

    //public interface IHeroFactory
    //{
    //    IMovement CreateMovement();
    //    IWeapon CreateWeapon();
    //}

}