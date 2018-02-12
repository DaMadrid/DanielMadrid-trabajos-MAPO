using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201829_practica2
{
    class CTelefono:Campos
    {
        public CTelefono()
        {
            Telefono telefono = new Telefono();
     
            AsignarTexto(telefono);
        }
        public override void Verificacion(string entrada)
        {
            Console.WriteLine("El telefono esta:");
            texto.usarTexto(entrada);
        }
    }
}
