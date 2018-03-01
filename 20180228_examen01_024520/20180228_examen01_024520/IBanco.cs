using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180229_examen1_24520
{
    abstract class Banco
    {
        public abstract void Mandar(Itransferencia atransferencia, Iprotocolo protocolo, Banco remitente);
        public abstract void Recivir(Itransferencia atransferencia, Iprotocolo protocolo, string name);
        Iprotocolo tipo;
        public abstract string getName();
        public abstract Iprotocolo getpr();

    }
}
