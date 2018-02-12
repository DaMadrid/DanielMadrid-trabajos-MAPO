using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _201829_practica2
{
    class UserName:ITexto
    {
        public void usarTexto(string entrada)
        {
            


            if (entrada.Contains("@") ==false)
            {
                Console.WriteLine("Nombre de usuario verificado");
            }
            else
            {
                Console.WriteLine("Nombre de usuario inadecuado intente de nuevo");
            }

        }
    }
}
