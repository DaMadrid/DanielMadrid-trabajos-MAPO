using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_01_18_practica2
{
    class Queen : character
    {

        BowAndArrow BA = new BowAndArrow();
        public Queen()
        {

            Setweapon(BA);

        }
        public override void fight()
        {
            Console.WriteLine("peleas como una reina usando:");
            weapon.useweapon();

        }
    }
}
