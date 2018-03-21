using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_actividad
{
    class cicloRGB:ICommand
    {
        Luz Luz;
        public cicloRGB(Luz luz){
            this.Luz = luz;
        }

        public void execute()
        {
            Luz.RGB();
        }

        public void undo()
        {
            Luz.Normal();
        }
    }
}
