using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_actividad
{
    class LuzNormal : ICommand
    {
        Luz Luz;
        public LuzNormal(Luz luz) {
            this.Luz = luz;
        }
        public void execute()
        {
            Luz.Normal();
        }

        public void undo()
        {
            Luz.RGB();
        }
    }
}
