using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180213_practica
{
    class Cliente:IObservador
    {
        String Name;
        String Direccion;
        private static Random r = new Random();
        //Random r = new Random();
        int CId; 

        public Cliente(string name, string direccion) {
            this.Name = name;
            this.Direccion = direccion;
           CId = r.Next(1111, 9999);
        }
        public int getId()
        { return this.CId; }
        public string getName()
        { return this.Name; }
        public string getDireccion()
        { return this.Direccion; }

        public void Pedido( int peso, ISujeto prov) {

            prov.Orden(getId(), getDireccion(),  getName(),  peso,prov.ToString());
            
        }
        public void Update(paquete paq) {
            if (paq.pro.Equals("DHL")) { Console.ForegroundColor = ConsoleColor.Red; }
            else if (paq.pro.Equals("FedEx")) { Console.ForegroundColor = ConsoleColor.Green; }
            else if (paq.pro.Equals("Correos De Mexico")) { Console.ForegroundColor = ConsoleColor.Yellow; }

            if (paq.dist < 10)
            {
                Console.WriteLine("Producto recibido");
                Console.WriteLine("Actualizacion Paquete con ID:{0} \n Nombre del destinatario: {1} \n Peso del paquete{2} \n Llegada inminente o ya recibida \n Proveedor: {3} \n", paq.id, paq.nom, paq.pes, paq.pro);
            }
            else
            {
                Console.WriteLine("Actualizacion Paquete con ID:{0} \n Nombre del destinatario: {1} \n Peso del paquete{2} \n Distancia hasta el punto de envio: {3} km \n Proveedor: {4} \n", paq.id, paq.nom, paq.pes, paq.dist, paq.pro);
            }   

            Console.ResetColor();
        }
    }
}
