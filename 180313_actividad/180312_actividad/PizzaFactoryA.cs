using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180313_actividad
{
    class PizzaFactoryA:Factory
    {
        public override IPizza OrderPizza(String PizzaType)
        {
            if (PizzaType == null)
            {
                return null;
            }
            switch (PizzaType)
            {
                case "Mexicana":

                    Console.Write("Hecha en la PIZZA FACTORYA ");
                    return new Mexicana();
                    break;
                case "Peperoni":
                    Console.Write("Hecha en la PIZZA FACTORYA ");
                    return new Peperoni();
                    break;
                default:
                    return null;
                    break;
            }
            


            
        }
    }
}

