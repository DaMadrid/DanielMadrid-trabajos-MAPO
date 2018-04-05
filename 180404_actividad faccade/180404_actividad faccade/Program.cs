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
            var bocina = new Bocinas();
            var tv = new TV();
            var vhs = new VHS();
            var vhsr = new VHS_rewinder();
            var luz = new Luces();
            var faccade = new Faccade(vhs,vhsr,bocina,tv,luz);
            faccade.WatchVHS();
            
            faccade.Shutoff();
        }
    }
}
