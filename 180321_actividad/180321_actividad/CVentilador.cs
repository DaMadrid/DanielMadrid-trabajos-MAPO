using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_actividad
{
    class CVentilador : ICommand
    {
        Ventilador Ventilador;
        public CVentilador(Ventilador ventilador) {
           this.Ventilador= ventilador;
        }
        public void execute()
        {
            Ventilador.execute();
       
        }

        public void undo()
        {
            Ventilador.Undo();
        }
    }
}
