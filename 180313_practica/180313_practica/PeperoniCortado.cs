using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180313_actividad
{
    class PeperoniCortado:Ingredientes
    {
        public int precio = 10;
        IPizza Pizza;
        private string descripccion = " se uso peperoni como topping ";
        public PeperoniCortado(IPizza pizza)
        {
            Pizza = pizza;

        }
        public override int costo()
        {
            precio = precio + Pizza.costo();
            return precio;
        }
        public override string getDescripcion()
        {
            return Pizza.getDescripcion() + descripccion;
        }
        public override void ImprimirInfo()
        {

            Console.WriteLine("Descripcion: " + getDescripcion() + "\n Total: " + costo());
        }


    }
}
