using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180206_act2
{
    class Program
    {
        static void Main(string[] args)
        {
            WeaterTracker provider = new WeaterTracker();
            Displays observador1 = new Displays("DisplayA");
            observador1.Subscribe(provider);
            Displays observador2 = new Displays("DisplayB");
            observador2.Subscribe(provider);

            provider.TrackWeater(new WeaterWrapper(17,30,20));
            //observador1.Unsubscribe();
            provider.TrackWeater(new WeaterWrapper(10, 22,13));
            provider.TrackWeater(new WeaterWrapper(-2, 15, 30));
            //provider.TrackWeater(null);
            provider.EndTransmission();
            Console.ReadLine();
        }
    }
}
