using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_actividad
{
    class OFFl:ICommand
    {
        Luz Luz;
        public OFFl(Luz luz) {
            this.Luz = luz;
        }
        public void execute()
        {
            Luz.off();  
        }

        public void undo()
        {
            Luz.On();
        }
    }
}
