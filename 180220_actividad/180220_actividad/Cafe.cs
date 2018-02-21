using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180220_actividad
{
    class Cafe:AbstractBebida
    {
        
        string Descripcion= "un cafe con: ";
        string Size;
        int precio;



        public Cafe( string tamaño)
        {
           
            this.Size = tamaño;
        }
        public override int Costo()
        {
            if (Size.Equals("grande")) { precio = 50; }
            else if (Size.Equals("mediano")) { precio = 40; }
            else if(Size.Equals("chico")) { precio = 30; }
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



        public  override string Tamaño()
        {
            return Size; 
        }
    }
}
