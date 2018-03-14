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
            PFA.OrderPizza("Mexicana");
            PFA.OrderPizza("Peperoni");
            var PFB = new PizzaFactoryB();
            PFB.OrderPizza("Mexicana");
            PFB.OrderPizza("Peperoni");
            Console.Read();
        }
    }
}
