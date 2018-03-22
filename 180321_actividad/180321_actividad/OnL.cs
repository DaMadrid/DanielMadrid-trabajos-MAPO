using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_actividad
{
    class OnL : ICommand
    {
        Luz Luz;
        public OnL(Luz luz) {
            this.Luz = luz;
        }
        public void execute()
        {
            Luz.On();
        }

        public void undo()
        {
            Luz.off();
        }
    }
}
