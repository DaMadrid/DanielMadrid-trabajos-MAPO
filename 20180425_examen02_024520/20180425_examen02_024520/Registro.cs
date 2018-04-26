using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_Examen02_024520
{
    class Registro
    {

        List<string> list3 = new List<string>();
        public void EscribirRegistro(string Orden) {
            File.AppendAllText(@"c:\path\file.txt", Orden + Environment.NewLine);
        }
        public void LeerRegistro() {
            var list = File.ReadLines("C:")
           .Select(line =>line)
           .ToList();
            foreach (var nombre in list)
            {
                Console.WriteLine(nombre+"\n");

            }
         
        }
   //     public void BorrarRegistro() { }
        

    }
}
