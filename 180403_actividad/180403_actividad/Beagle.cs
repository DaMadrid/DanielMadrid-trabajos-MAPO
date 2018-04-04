using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180403_actividad
{
    class Beagle: IDog
    {
        public void Bark()
        {
        Console.WriteLine("Bark bark");
    }

        public void Bite()
        {
        Console.WriteLine("Dog bite attack");
    }
    }
}
