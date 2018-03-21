using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_actividad
{
    class Program
    {
        static void Main(string[] args)
        {
            var UnaLuz = new Luz();
            var UnaBocina = new Bocina();
            var LOO = new OFFl(UnaLuz);
            var LN = new OnL(UnaLuz);
            var RGB = new cicloRGB(UnaLuz);
            var LNormal = new LuzNormal(UnaLuz);
            var mute = new silenciar(UnaBocina);
            var SuVo = new SubirV(UnaBocina);
            var Bon = new onB(UnaBocina);
            var Bof = new onB(UnaBocina);

           Sumoner Controler = new Sumoner();

            Controler.SetCommand(LN);
            Controler.dosomething();
            Controler.undoSomething();
            Controler.SetCommand(RGB);
            Controler.dosomething();
            Controler.SetCommand(Bon);
            Controler.dosomething();
            Controler.SetCommand(mute);
            Controler.dosomething();
            Controler.undoSomething();
        }
    }
}
