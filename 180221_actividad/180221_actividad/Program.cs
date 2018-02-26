using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _180221_actividad
{
    class Program
    {
        static void Main(string[] args)
        {



            //string path = @"C:Users\MADRI\source\repos\180221_actividad\180221_actividad\bin\Ejemplo.txt";
            string path = "NoImporta.txt";
            try
            {
                if (File.Exists(path))
                {
                   //  File.Delete(path);
                  
                }

                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("HOLA SOY UNOS CARACTERS EN MINUSCULA");
               
                }

                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (LowerInputStream sr = new LowerInputStream(fs))
                    {

                        while (sr.Peek() >= 0)
                        {
                            Console.WriteLine(Convert.ToChar(sr.Read()) );
                           
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            Console.ReadLine();
        }
    }
}

        
    

