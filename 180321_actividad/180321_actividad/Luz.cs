using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_actividad
{
    class Luz
    {
        public void On() {Console.WriteLine("Luz encendida"); }
        public void off() { Console.WriteLine("Luz apagada"); }
        public void RGB() { Console.WriteLine("Luz en un ciclo de colores RGB"); }
        public void Normal() { Console.WriteLine("Luz en modo normal"); }
    }
}
