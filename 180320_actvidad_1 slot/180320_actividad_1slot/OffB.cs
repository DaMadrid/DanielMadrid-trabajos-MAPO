using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_actividad
{
    class OffB : ICommand
    {
        Bocina Bocina;
        public OffB(Bocina bocina) {
            this.Bocina = bocina;
        }
        public void execute()
        {
            Bocina.off();
        }

        public void undo()
        {
            Bocina.On();
        }
    }
}
