using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180313_actividad
{
    class Mexicana : IPizza
    {
        public Mexicana()
        {
            Console.WriteLine(preparar());
        }
        public void cortar()
        {
            
        }

        public void empacar()
        {
           
        }

        public void hornear()
        {
           
        }

        public string preparar()
        {
            hornear();
            cortar();
            empacar();
           string resultado=" una pizza mexicana";
            return resultado;
        }
    }
}
