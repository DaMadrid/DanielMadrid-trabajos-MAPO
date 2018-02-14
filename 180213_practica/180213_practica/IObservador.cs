using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180213_practica
{
    interface IObservador
    {
        string getName();
        string getDireccion();
        int getId();
        void Update(paquete paquete);
    }
}
