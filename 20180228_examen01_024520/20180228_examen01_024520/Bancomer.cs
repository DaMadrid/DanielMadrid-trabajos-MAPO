using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180229_examen1_24520
{
    class Bancomer : Banco

    {
        public string NAME = "Bancomer";
        Iprotocolo protocolo;

        public Bancomer(Iprotocolo protocolo)
        {
            this.protocolo = protocolo;
        }


        public override void Mandar(Itransferencia atransferencia, Iprotocolo protocolo, Banco banco)
        {

            banco.Recivir(atransferencia, protocolo, NAME);
        }

        public override void Recivir(Itransferencia atransferencia, Iprotocolo protocolo, string name)
        {
            Console.WriteLine("Origen:" + name + "Encoding:" + atransferencia.setP(this.protocolo) + "Numero de cuenta" + atransferencia.getcuenta() + "IdTRANFER" + atransferencia.getid() + "Monto" + atransferencia.getmonto());
        }


        public override string getName()
        {
            return NAME;
        }
        public override Iprotocolo getpr()
        {
            return protocolo;
        }
    }
}
