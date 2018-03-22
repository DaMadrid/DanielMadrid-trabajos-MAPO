using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_actividad
{
    class SubirV:ICommand
    {
        Bocina Bocina;
        public SubirV(Bocina bocina) {
            this.Bocina = bocina;
        }

        public void execute()
        {
            Bocina.subirVolumen();
        }

        public void undo()
        {
            Bocina.Silenciar();
        }
    }
}
