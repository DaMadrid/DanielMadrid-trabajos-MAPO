using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180313_actividad
{
    class Peperoni : IPizza
    {

        public Peperoni(string Tamaño)
        {
            this.tamaño = Tamaño;
            Console.WriteLine(preparar());
        }
        public override void cortar()
        {

        }

        string Descripcion = "una pizza De peperoni con: ";
        string tamaño;
        int precio;
        public override int costo()
        {
            if (tamaño.Equals("grande")) { precio = 50; }
            else if (tamaño.Equals("mediano")) { precio = 40; }
            else if (tamaño.Equals("chico")) { precio = 30; }
            return precio;
        }

        public override string getDescripcion()
        {
            return Descripcion;
        }
        public override void ImprimirInfo()
        {
            Console.WriteLine("Descripcion: " + getDescripcion() + "\n Total: " + costo());
        }


        public override void hornear()
        {

        }

        public override string preparar()
        {
            hornear();
            cortar();
            empacar();
            string resultado = " una pizza de peperoni";
            return resultado;
        }
    }
}
