using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180220_actividad
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Cafe( "mediano");
            var ca= new Agua(c);
            var caf = new Leche(ca);
            var cafe = new Crema(caf);
            cafe.PrintInfo();

            var M = new Mocha("grande");
            var Mo = new Chocolate(M);
            var Moc = new Leche(Mo);
            var Mocha = new Crema(Moc);
            Mocha.PrintInfo();

            var L = new Latte("chico");
            var La = new Chocolate(L);
            var Lat = new Leche(La);
            var Latte = new Azucar(Lat);
            Latte.PrintInfo();
        }

    }
}
