using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_Examen02_024520
{
    class Cocinar : IOrdenes
    {
        string name = "Cocinar";
        

        public void Execute()
        {
           
            Console.WriteLine("Cocinado");  
        }

        public string getName()
        {
            return name;  
        }
    }
}
