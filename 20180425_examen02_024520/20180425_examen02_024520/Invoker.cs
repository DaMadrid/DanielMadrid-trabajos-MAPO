using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_Examen02_024520
{
    class Invoker
    {
        IOrdenes Command;
        
        public void SetCommand(IRobot robot,IOrdenes ordenes)  {

            robot.SetWork(ordenes);

        }
    }
}
