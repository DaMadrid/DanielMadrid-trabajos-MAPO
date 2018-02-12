using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180206_actividad1
{
    class DisplayA : IObserver
    {
        private float temp = 0;
        private float presure= 0;
        private float humidity= 0;
       
        public void Update(float t,float p ,float h) {
            this.temp = t;
            this.presure = p;
            this.humidity = h;
        }
        public void print() {
            Console.WriteLine("¡¡¡¡¡Display A!!!\n La temperatura es: "+temp+"\n La presion es: "+presure+"\n La humedad es: "+humidity);
        }
    }
}
