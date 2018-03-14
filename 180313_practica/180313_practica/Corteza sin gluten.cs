using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180313_actividad
{
    class Corteza_sin_gluten : Ingredientes
    {
        public int precio = 11;
        IPizza Pizza;
        private string descripccion = " una corteza sin gluten ";
        public Corteza_sin_gluten(IPizza pizza)
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
