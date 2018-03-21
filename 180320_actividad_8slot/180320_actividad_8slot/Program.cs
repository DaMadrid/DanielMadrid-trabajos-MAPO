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
            var Bof = new OffB(UnaBocina);

           Summoner Controler = new Summoner();

            Button button1 = new Button();
            Button button2 = new Button();
            Button button3 = new Button();
            Button button4 = new Button();
            Button button5 = new Button();
            Button button6 = new Button();
            Button button7 = new Button();
            Button button8 = new Button();

            Controler.BindCommand(LN, button1);
            Controler.BindCommand(LOO, button2);
            Controler.BindCommand(RGB, button3);
            Controler.BindCommand(LNormal, button4);
            Controler.BindCommand(Bon, button5);
            Controler.BindCommand(Bof, button6);
            Controler.BindCommand(mute, button7);
            Controler.BindCommand(SuVo, button8);
            Console.WriteLine("\n");
            Controler.pressButton(button1);
            Controler.pressButton(button3);
            Controler.pressButton(button4);
            Controler.pressButton(button2);
            Console.WriteLine("\n");
            Controler.pressButton(button5); 
            Controler.pressButton(button7);
            Controler.pressButton(button8);
            Controler.pressButton(button6);
            Console.WriteLine("\n");
            Controler.pressButton(button1);
            Controler.undoButton();
            Console.WriteLine("\n");
            Controler.pressButton(button5);
            Controler.pressButton(button7);
            Controler.undoButton();
        }
    }
}
