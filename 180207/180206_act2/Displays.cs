using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180206_act2
{
    public class Displays : IObserver<WeaterWrapper>
    {
        private IDisposable unsubscriber;
        private string instName;
        private float t;
        private float p;
        private float h;
        
        public Displays(string name)
        {
            this.instName = name;
        }

        public string Name
        { get { return this.instName; } }

        public virtual void Subscribe(IObservable<WeaterWrapper> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }

        public virtual void OnCompleted()
        {
            Console.WriteLine("Transmision terminada--- {0}.", this.Name);
            this.Unsubscribe();
        }

        public virtual void OnError(Exception e)
        {
            Console.WriteLine("{0}: No se pudieron adquirir datos.", this.Name);
        }

        public virtual void OnNext(WeaterWrapper value)
        {
            Console.WriteLine("{2}: La temperatura es: {0} grados celcius, La presion es: {1}, la humedad es:{3}", value.temp, value.pres, this.Name,value.hum);
            this.t = value.temp;
            this.p = value.pres;
            this.h = value.hum;
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}
