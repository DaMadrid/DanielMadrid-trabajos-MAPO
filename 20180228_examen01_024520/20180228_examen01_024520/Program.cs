using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180229_examen1_24520
{
    class Program
    {
        static void Main(string[] args)
        {
            var JASON = new JSON();
            var CSV = new CSV();
            var HTML = new HTML();
            

            var HSBC = new HSBC(JASON);
            var t1 = new transferencia(1, 1234, 21, HSBC);

            var BANCO = new Banamex(CSV);
            HSBC.Mandar(t1, JASON, BANCO);
        }
    }
}
