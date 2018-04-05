using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180404_actividad_faccade
{
    class Program
    {
        static void Main(string[] args)
        {
            var faccade = new Faccade();
            faccade.WatchVHS();
            
            faccade.Shutoff();
        }
    }
}
