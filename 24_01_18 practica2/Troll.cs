using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_01_18_practica2
{
    public class Troll : character
    {
        SwordBehavior sw = new SwordBehavior();
        public Troll()
        {
            Setweapon(sw);
        }


        public override void fight()
        {
            Console.WriteLine("peleas como un troll usando:");
            weapon.useweapon();
        }
    }
}
