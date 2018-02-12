using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_01_18_practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            BowAndArrow BnA = new BowAndArrow();
            knifeBehavior knife = new knifeBehavior();
            SwordBehavior sword = new SwordBehavior();
            AxeBehavior axe = new AxeBehavior();

            Queen queen = new Queen();
            Knight knight = new Knight();
            King king = new King();
            Troll troll = new Troll();



            queen.fight();

            queen.Setweapon(knife);
            queen.fight();

            queen.Setweapon(BnA);
            queen.fight();

            queen.Setweapon(sword);
            queen.fight();

            queen.Setweapon(axe);
            queen.fight();



            Console.ReadLine();
        }
    }
}
