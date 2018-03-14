using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180313_actividad
{
    public abstract class IPizza
    {

       public virtual string preparar() {
            return "Texto generico";
        }
        public virtual void hornear() { }
       public virtual void empacar() { }
        public virtual void cortar() { }
        public abstract int costo();
        public abstract string getDescripcion();
        public abstract void ImprimirInfo();
    }
}
