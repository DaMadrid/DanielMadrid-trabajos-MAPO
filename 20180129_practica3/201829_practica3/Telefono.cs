using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _201829_practica2
{
    class Telefono:ITexto
    {

        public void usarTexto(string entrada)
        {
            int algo;
            if (int.TryParse(entrada, out algo))
            {

                Console.WriteLine("Es un numero valido");

            }
            else Console.WriteLine("No es un numero valido");
        }
           


        
    }
}