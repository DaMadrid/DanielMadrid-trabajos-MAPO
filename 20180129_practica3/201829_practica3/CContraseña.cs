using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201829_practica2
{
    class CContraseña : Campos
    {
        public CContraseña()
        {
            Contraseña contraseña = new Contraseña();
            AsignarTexto(contraseña);

        }
        public override void Verificacion(string entrada)
        {
            Console.WriteLine("Su contraseña esta:");
            texto.usarTexto(entrada);
        }
    }
}
