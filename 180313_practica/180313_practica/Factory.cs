using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180313_actividad
{
    abstract class Factory
    {
        public abstract IPizza OrderPizza(string pizzatype,string tamaño);

        
    }
}
