using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180206_actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayA DA= new DisplayA();
            DisplayB DB = new DisplayB();
            WaterData WD = new WaterData();
            WD.Register(DA);
            WD.Register(DB);
            WD.MesurementChange(10,20,30);
            DB.print();
            DA.print();
        }
    }
}
