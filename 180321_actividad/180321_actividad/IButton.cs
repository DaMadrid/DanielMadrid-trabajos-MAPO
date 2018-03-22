using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_actividad
{
   interface IButton

    {
        void Bind(ICommand command);
        void Dosomething();
        void Undo();
    }
}
