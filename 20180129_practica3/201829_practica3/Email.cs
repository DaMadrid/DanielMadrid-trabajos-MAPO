using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace _201829_practica2
{
    class Email:ITexto
    {
        public void usarTexto(string entrada)
        {

            try
            {
                MailAddress mailAddress = new MailAddress(entrada);
                Console.WriteLine("Verificado");
              
            }
            catch (FormatException)
            {
                Console.WriteLine("No permitido, intente de nuevo con un formato valido");
            }
        }
    }
}
