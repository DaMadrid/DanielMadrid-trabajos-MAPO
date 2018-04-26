using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_Examen02_024520
{
    class Robot : IRobot
    {
        String Nombre="";
        public Robot(string nombre) {
            this.Nombre = nombre;
        }
        IOrdenes ordenes;
        public void SetWork(IOrdenes ordenes)
        {
            this.ordenes = ordenes;
        }

        public void Work()
        {
            ordenes.Execute();
        }
    }
}
