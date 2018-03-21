using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_actividad
{
    class onB : ICommand
    {
        Bocina Bocina;
        public onB(Bocina bocina) {
            this.Bocina = bocina;
        }
        public void execute()
        {
            Bocina.On(); 
        }

        public void undo()
        {
            Bocina.off();
        }
    }
}
