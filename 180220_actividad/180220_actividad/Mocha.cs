using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180220_actividad
{
    class Mocha:AbstractBebida
    {
        private string Descripcion="Un Mocha con: ";
        private string Size;
        private int precio;

        public Mocha( string tamaño) {
           
            this.Size = tamaño;
        }

        public override int Costo()
        {
            if (Size.Equals("grande")) { precio = 59; }
            else if (Size.Equals("mediano")) { precio = 49; }
            else if (Size.Equals("chico")) { precio = 39; }
            return precio;
        }

        public override string GetDescripcion()
        {
            return Descripcion;
        }


        public override void PrintInfo()
        {
            Console.WriteLine("Descripcion: " + GetDescripcion() + "\n Total: " + Costo());
        }
        public override string Tamaño()
        {
            return Size;
        }
    }
}
