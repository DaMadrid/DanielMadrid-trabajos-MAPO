using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_actividad
{
    class Ventilador
    {
       public int state=0;
        public void execute() { if (state >= 3)
            { state = 0; }
            else { state = state + 1; }
            operational();
        }
        public void Undo() {
            if (state <= 0) { state = 1; }

            else { state = state - 1; }
            operational();
        }

            

    public void high() { Console.WriteLine("Alta velocidad");
            state = 3;
        }
        public void medium() { Console.WriteLine("media velocidad");
            state = 2;
        }
        public void low() { Console.WriteLine("baja velocidad");
            state = 1;
        }
        public void off() { Console.WriteLine("apagado");
            state = 0;
           
        }
    public void operational()
        {
            switch (state)
            {
                case 0:
                    off();
                    break;
                case 1:
                    low();
                    break;
                case 2:
                    medium();
                    break;
                case 3:
                    high();
                    break;
            }
        }

}
}
