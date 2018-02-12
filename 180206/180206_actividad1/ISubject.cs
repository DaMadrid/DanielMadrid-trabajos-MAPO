using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180206_actividad1
{
    interface ISubject
    {
       void Notify();
        void Remove(IObserver observer);
        void Register(IObserver observer);
        void MesurementChange(float t, float p, float h);
    }
}
