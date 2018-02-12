using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201829_practica2
{
    class CEmail:Campos
    {
        public CEmail()
        {
            Email email = new Email();
            AsignarTexto(email);
        }
        public override void Verificacion(string entrada)
        {
            Console.WriteLine("Su Email esta:");
            texto.usarTexto(entrada);
        }
    }
}
