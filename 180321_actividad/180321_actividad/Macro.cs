using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_actividad
{
    class Macro : IButton
    {
        List<ICommand> Macro1 = new List<ICommand>();

        public void Bind(ICommand command)
        {
            Macro1.Add(command);
        }

        public void Dosomething()
        {
            foreach (var icommand in Macro1)
            {
                icommand.execute();
            }
        }

        public void Undo()
        {
            foreach (var icommand in Macro1)
            {
                icommand.undo();
            }
        }
    }
}
