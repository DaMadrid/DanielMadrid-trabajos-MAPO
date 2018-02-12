using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180206_act2
{
   public struct WeaterWrapper
    {
        private float temperature;
        private float presure;
        private float humidity;
        public WeaterWrapper(float temp,float pres, float hum) {
            this.temperature = temp;
            this.presure = pres;
            this.humidity = hum;
        }
        public float temp
        { get { return this.temperature; } }
        public float pres
        { get { return this.presure; } }
        public float hum
        { get { return this.humidity; } }

    }
}
