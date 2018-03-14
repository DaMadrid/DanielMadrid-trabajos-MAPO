using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180313_actividad
{
    class Program
    {
        static void Main(string[] args)
        {
            var PFA = new PizzaFactoryA();
            PFA.OrderPizza("Mexicana", "chica");
            PFA.OrderPizza("Peperoni", "mediana");
            PFA.OrderPizza("Hawaiana", "grande");
            var PFB = new PizzaFactoryB();
            PFB.OrderPizza("Mexicana","grande");
            PFB.OrderPizza("Peperoni", "chica");
            PFB.OrderPizza("Hawaiana", "mediana");

            Console.Read();
        }
    }
}
