using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180404_actividad_faccade
{
    class Bocinas
    {
        public void On() { Console.WriteLine("Speaker on"); }
        public void Off() { Console.WriteLine("Speaker off"); }
        public void RaiseV() { Console.WriteLine("Raising volume"); }
        public void LowerV() { Console.WriteLine("Lowering volume"); }
    }
}
