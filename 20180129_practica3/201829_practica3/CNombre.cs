using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201829_practica2
{
    class CNombre:Campos
    {
        public CNombre()
        {
            Nombre nombre = new Nombre();
            AsignarTexto(nombre);
        }
        public override void Verificacion(string entrada)
        {
            Console.WriteLine("El nombre esta:");
            texto.usarTexto(entrada);
        }
    }
}
