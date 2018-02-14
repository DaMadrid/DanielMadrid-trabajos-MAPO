using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180213_practica
{
    interface ISujeto
    {
       
        
            void Notify();
            void Remove(IObservador observer);
            void Register(IObservador observer);
            void Orden(int CID,string dir, string nombre, int peso, string prov);
            
            
        
    }
}
