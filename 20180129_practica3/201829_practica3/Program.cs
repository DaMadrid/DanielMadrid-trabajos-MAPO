using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201829_practica2
{
    class Program
    {
        static void Main(string[] args)
        {

            CNombre nombre = new CNombre();
            CTelefono numero = new CTelefono();
            CEmail  email = new CEmail();
            CUserName userName = new CUserName();
            CContraseña contraseña = new CContraseña();
        
            Console.WriteLine("Ingrese nombre");
            string InputNombre = Console.ReadLine();
            nombre.Verificacion(InputNombre);
          
    

            Console.WriteLine("Ingrese su numero de telefono");
            string InputTelefono = Console.ReadLine();
            numero.Verificacion(InputTelefono);
        

            Console.WriteLine("Ingrese su email" );
            string InputEmail = Console.ReadLine();
            email.Verificacion(InputEmail);
          

            Console.WriteLine("ingrese su nombre de usuario");
            string InputUser = Console.ReadLine();
            userName.Verificacion(InputUser);
        
            Console.WriteLine("ingrese su contraseña(letras y numeros)");
            string InputContraseña = Console.ReadLine();
           contraseña.Verificacion(InputContraseña);
            Console.ReadLine();
        }
    }
}
