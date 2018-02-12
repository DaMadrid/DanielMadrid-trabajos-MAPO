using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201829_practica2
{
    class Nombre:ITexto
    {
        public void usarTexto(string entrada) {
          
            if (entrada.All(Char.IsLetter))
            {
                Console.WriteLine(" verificado");
            }
            else
            {
                Console.WriteLine(" Entrado no permitida intente de nuevo");
            }



        }
    }
}
