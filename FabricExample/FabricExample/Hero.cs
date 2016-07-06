using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricExample.Factories;

namespace FabricExample
{
    public class Hero
    {
        private IWeapon _weapon;
        private IMovement _movement;
        //public Hero(IHeroFactory factory)
        //{
        //    _weapon = factory.CreateWeapon();
        //    _movement = factory.CreateMovement();
        //}
        public Hero(HeroFactory factory)
        {
            _weapon = factory.CreateWeapon();
            _movement = factory.CreateMovement();
        }
        public void Run()
        {
            _movement.Move();
        }
        public void Hit()
        {
            _weapon.Hit();
        }
    }
}
