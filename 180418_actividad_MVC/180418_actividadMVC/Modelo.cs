using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180418_actividadMVC
{
    class Modelo
    {
        private int temp;
        public int suma(int uno, int dos) {


            int x = uno + dos;
            temp = x;
            return x;
        }
        public int Resta(int uno, int dos)
        {

            int x = uno - dos;
            temp = x;
            return x;
        }
        public int Multi(int uno, int dos)
        {

            int x = uno * dos;
            temp = x;
            return x;
        }
        public int Div(int uno, int dos)
        {
          
            int x = uno/ dos;
            temp = x;
            return x;
        }
        public int Ans() {
            return temp;
        }
    }
}
