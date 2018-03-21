using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_actividad
{
    class Summoner
    {
        ICommand commando;
        public void SetCommand(ICommand command) {
            this.commando = command;
        }
        public void dosomething() {
            commando.execute();
        }
        public void undoSomething()
        {
            commando.undo();

        }
    }
}
