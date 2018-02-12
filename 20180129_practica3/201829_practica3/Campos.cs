using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201829_practica2
{
    abstract class Campos
    {
        public ITexto texto;


        public void AsignarTexto(ITexto texto) {
            this.texto = texto;
        }
        abstract public void Verificacion(string entrada);
    }
}
