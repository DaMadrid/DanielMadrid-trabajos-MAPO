using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180220_actividad
{
    class Latte:AbstractBebida
    {
        string Descripcion= "Un Latte con: ";
        string Size;
        int precio;
        public Latte( string tamaño)
        {
            
            this.Size = tamaño;
        }

        public override int Costo()
        {
            if (Size.Equals("grande")) { precio = 55; }
            else if (Size.Equals("mediano")) { precio = 45; }
            else if (Size.Equals("chico")) { precio = 35; }
            return precio;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Descripcion: " + GetDescripcion() + "\n Total: " + Costo());
        }
        public override string GetDescripcion()
        {
            return Descripcion;
        }



        public override string Tamaño()
        {
            return Size;
        }
    }
}
