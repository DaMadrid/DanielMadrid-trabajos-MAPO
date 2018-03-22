using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_actividad
{
    class Summoner
    {
        IButton currentB;
        public void BindCommand(ICommand command,IButton button) {
            button.Bind(command);
        }
        public void append(ICommand command) {  }
        public void pressButton(IButton button) { button.Dosomething();
            this.currentB = button;
        }
        public void undoButton() { currentB.Undo(); }
       
    }
}
