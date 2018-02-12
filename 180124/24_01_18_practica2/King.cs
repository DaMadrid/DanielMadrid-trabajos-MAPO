using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_01_18_practica2
{
    class King : character
    {
        knifeBehavior knife = new knifeBehavior();
        public King()
        {
            Setweapon(knife);
        }
        public override void fight()
        {
            Console.WriteLine("peleas como un Rey usando:");
            weapon.useweapon();
        }
    }
}
