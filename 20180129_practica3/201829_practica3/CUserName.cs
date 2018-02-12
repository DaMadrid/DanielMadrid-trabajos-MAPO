using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201829_practica2
{
    class CUserName:Campos
    {
        public CUserName() {
            UserName userName = new UserName();
            AsignarTexto(userName);
        }

        public override void Verificacion(string entrada)
        {

            Console.WriteLine("El nombre de usario esta:");
            texto.usarTexto(entrada);
        }
    }
}
