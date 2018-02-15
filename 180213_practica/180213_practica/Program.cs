using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180213_practica
{
    class Program
    {
        static void Main(string[] args)
        {
            DHL dHL = new DHL();
            FedEx fedex = new FedEx();
            Correos CDM = new Correos();
            Cliente Carlos = new Cliente("Carlos","123 Guatemala");
            Cliente Pepe = new Cliente("Pepe", "12345 Mexico");
            Cliente Juan= new Cliente("Pepe", "12345 Mexico");
            dHL.Register(Carlos);
            dHL.Register(Pepe);
            dHL.Register(Juan);

            CDM.Register(Carlos);
            CDM.Register(Pepe);
            CDM.Register(Juan);

            fedex.Register(Carlos);
            fedex.Register(Pepe);
            fedex.Register(Juan);

            Carlos.Pedido(32, dHL);
            Pepe.Pedido(13, dHL);
            Juan.Pedido(11, dHL);
             
            Carlos.Pedido(11, fedex);
            Pepe.Pedido(18, fedex);
            Juan.Pedido(14, fedex);

            Carlos.Pedido(15, CDM);
            Pepe.Pedido(9, CDM);
            Juan.Pedido(4,CDM);

         
            Console.ReadLine();
        }
    }
}
