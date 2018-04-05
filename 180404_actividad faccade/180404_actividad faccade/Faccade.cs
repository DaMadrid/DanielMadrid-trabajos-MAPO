﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180404_actividad_faccade
{
    class Faccade
    {
        VHS Vhs;
        VHS_rewinder Vhs_r;
        Bocinas Bocinas;
        TV Tv;
        Luces LUces;
        public Faccade (VHS vhs,VHS_rewinder rewinder,Bocinas bocinas,TV tv,Luces luces){
            this.Vhs = vhs;
            this.Vhs_r = rewinder;
            this.Bocinas = bocinas;
            this.Tv = tv;
            this.LUces = luces;
        }
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
