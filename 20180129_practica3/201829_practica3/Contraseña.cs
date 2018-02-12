using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _201829_practica2
{
    class Contraseña:ITexto
    {
        public void usarTexto(string entrada)
        {


            Regex rg = new Regex(@"^[a-zA-Z0-9\s,]*$");
            if (rg.IsMatch(entrada))
            {
                Console.WriteLine("verificada");
            }
            else
            {
                Console.WriteLine("No permitida, intente de nuevo");
            }

        }
    }
}
