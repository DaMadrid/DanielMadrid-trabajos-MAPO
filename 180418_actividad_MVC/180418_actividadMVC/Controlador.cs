using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180418_actividadMVC
{
    class Controlador
    {

        Modelo Mo = new Modelo();
        string temp;
        public string suma(string uno, string dos) {
            int x1 = 0;
            int x2 = 0;
            Int32.TryParse(uno, out x1);
            Int32.TryParse(dos, out x2);
            string r = Mo.suma(x1, x2).ToString();
            temp = r;
            return r;

        }
        public string multi(string uno, string dos) {
            int x1 = 0;
            int x2 = 0;
            Int32.TryParse(uno, out x1);
            Int32.TryParse(dos, out x2);
            string r = Mo.Multi(x1, x2).ToString();
            temp = r;
            return r;
        }
        public string resta(string uno, string dos) {
            int x1 = 0;
            int x2 = 0;
            Int32.TryParse(uno, out x1);
            Int32.TryParse(dos, out x2);
            string r = Mo.Resta(x1, x2).ToString();
            temp = r;
            return r;
        }
        public string div(string uno, string dos) {

            int x1 = 0;
            int x2 = 0;
            Int32.TryParse(uno, out x1);
            Int32.TryParse(dos, out x2);
            string r = Mo.Div(x1, x2).ToString();
            temp = r;
            return r;
        }
        public string Ans(){
            return temp;
        }



    }
}
