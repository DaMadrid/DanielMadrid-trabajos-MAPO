using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_Examen02_024520
{
    class LavarCarro : IOrdenes
    {
        string name = "LavarCarro";
        public void Execute()
        {
            Console.WriteLine("CarroLavado");
        }

        public string getName()
        {
            return name;
        }
    }
}
