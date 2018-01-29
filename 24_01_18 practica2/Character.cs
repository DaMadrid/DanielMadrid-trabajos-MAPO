using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_01_18_practica2
{
   public abstract class character
    {
        public IWeaponBehavior weapon;
        public abstract void fight();
        public void Setweapon(IWeaponBehavior w) { this.weapon = w; }
    }
}
