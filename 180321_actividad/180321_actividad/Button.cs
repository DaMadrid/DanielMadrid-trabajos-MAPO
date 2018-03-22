using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_actividad
{
    class Button : IButton
    {
        ICommand Command;
        public void Bind(ICommand comando) {
            this.Command = comando;
        }
        public void Dosomething()
        {
            Command.execute();
        }   

        public void Undo()
        {
            Command.undo();
        }
    }
}
