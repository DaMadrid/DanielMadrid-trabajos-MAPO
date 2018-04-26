using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_Examen02_024520
{
    class PintarCasas : IOrdenes
    {
        string name = "PintarCasas";
        public void Execute()
        {
            Console.WriteLine("CasaPintada");
        }

        public string getName()
        {
            return name;
        }
    }
}
