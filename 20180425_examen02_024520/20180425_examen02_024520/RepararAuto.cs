using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_Examen02_024520
{
    class RepararAuto : IOrdenes
    {
        string name = "repararAuto";
        public void Execute()
        {
            Console.WriteLine("Reparado");
        }

        public string getName()
        {
            return name;
        }
    }
}
