using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180404_actividad_faccade
{
    class VHS
    {
        public void On() { Console.WriteLine("VHS ON"); }
        public void Off() { Console.WriteLine("VHS OFF"); }
        public void Play() { Console.WriteLine("Playing tape"); }
        public void Stop() { Console.WriteLine("Stopping tape"); }
        public void Eject() { Console.WriteLine("Ejecting tape"); }
    }
}
