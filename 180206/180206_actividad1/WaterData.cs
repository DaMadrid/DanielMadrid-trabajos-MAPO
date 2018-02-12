using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180206_actividad1
{
    class WaterData:ISubject
    {
      private float temp;
      private float presure;
      private float hum;
        public List<IObserver> subscriptores = new List<IObserver>();
    
        
        public  WaterData() {

        }
        public void Remove(IObserver removido) {
            subscriptores.Remove(removido);
        }
        public void Register(IObserver registro) {
            subscriptores.Add(registro);
        }
        public void Notify() {
            foreach (IObserver subscriptor in subscriptores)
            {
                subscriptor.Update(temp,presure,hum);
            }
        }
        public void MesurementChange(float t,float p, float h) {
           
            this.temp = t;
            this.presure = p;
            this.hum = h;
            Notify();
        }

    }
}
