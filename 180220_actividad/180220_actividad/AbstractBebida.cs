using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180220_actividad
{
   abstract class AbstractBebida
    {
        
        string Size;
       
        public  abstract int Costo();
        public abstract void PrintInfo();

        public abstract string GetDescripcion();

        public virtual string Tamaño() { return Size; }
    }
}
