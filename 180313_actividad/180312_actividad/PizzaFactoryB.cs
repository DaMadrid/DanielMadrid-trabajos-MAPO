using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180313_actividad
{
    class PizzaFactoryB:Factory
    {
        public override IPizza OrderPizza(String PizzaType)
        {
            if (PizzaType == null)
            {
                return null;
            }
            if (PizzaType.Equals("Mexicana"))
                
            {
                Console.Write(" Hecha en la PIZZA FACTORYB ");
                return new Mexicana();
              
               
               
                
            }
            else if (PizzaType.Equals("Peperoni"))
            {
                Console.Write("Hecha en la PIZZA FACTORYB ");
                return new Peperoni();
              
            }
           

            return null;
        }
    }
}
