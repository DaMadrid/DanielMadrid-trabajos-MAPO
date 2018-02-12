using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180206_act2
{
    class WeaterTracker:IObservable<WeaterWrapper>
    {
        public WeaterTracker()
        {
            observers = new List<IObserver<WeaterWrapper>>();
        }

        private List<IObserver<WeaterWrapper>> observers;

        public IDisposable Subscribe(IObserver<WeaterWrapper> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<WeaterWrapper>> _observers;
            private IObserver<WeaterWrapper> _observer;

            public Unsubscriber(List<IObserver<WeaterWrapper>> observers, IObserver<WeaterWrapper> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }
        public void TrackWeater(Nullable<WeaterWrapper> weater)
        {
            foreach (var observer in observers)
            {
                if (!weater.HasValue)
                    observer.OnError(new WeaterUnknownException());
                else
                    observer.OnNext(weater.Value);
                
            }
        }




        public void EndTransmission()
        {
            foreach (var observer in observers.ToArray())
                if (observers.Contains(observer))
                    observer.OnCompleted();

            observers.Clear();
        }
    }
}
