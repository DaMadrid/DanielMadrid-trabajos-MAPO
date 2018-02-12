using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_01_18_practica2
{
    class Knight : character
    {
        AxeBehavior Ax = new AxeBehavior();
        public Knight()
        {
            Setweapon(Ax);
        }
        public override void fight()
        {
            Console.WriteLine("peleas como un Caballero usando:");
            weapon.useweapon();
        }
    }
}
