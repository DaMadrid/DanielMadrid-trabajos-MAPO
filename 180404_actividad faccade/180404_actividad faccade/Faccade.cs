using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180404_actividad_faccade
{
    class Faccade
    {
        VHS Vhs =new VHS();
        VHS_rewinder Vhs_r=new VHS_rewinder();
        Bocinas Bocinas = new Bocinas();
        TV Tv = new TV();
        Luces LUces = new Luces();
        public void WatchVHS() {
            Tv.On();
            Bocinas.On();
            LUces.On();
            Vhs_r.RewindTape();
            Vhs_r.Eject();
            Vhs.On();
            LUces.Dim();
            Vhs.Play();
        }
        public void Shutoff()
        {
            Tv.Off();
            Bocinas.Off();
            LUces.Off();
            Vhs.Eject();
            Vhs.Off();

            
        }


    }
}
