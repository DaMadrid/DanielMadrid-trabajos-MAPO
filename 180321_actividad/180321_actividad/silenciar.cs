using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_actividad
{
    class silenciar : ICommand
{

        Bocina Bocina;
        public silenciar(Bocina bocina) {
            this.Bocina = bocina;
        }
        public void execute()
        {
            Bocina.Silenciar();
        }

        public void undo()
        {
            Bocina.subirVolumen();
        }
    }
   
        
       
    }

