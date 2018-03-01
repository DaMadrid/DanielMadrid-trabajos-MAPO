using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180229_examen1_24520
{
    class transferencia:Itransferencia
    {
       private int id;
        private int monto;
        private int cuenta;
        Iprotocolo protocolo; 
        
        public transferencia(int TID, int monto, int cuenta,Banco protocolo) {
            
            this.id = TID;
            this.monto = monto;
            this.cuenta = cuenta;
            this.protocolo = protocolo.getpr();
        }
        public int getid() {
            return id;
        }
        public int getmonto()
        {
            return id;
        }
        public int getcuenta()
        {
            return id;
        }
        public string setP(Iprotocolo nuevo) {
            this.protocolo = nuevo;
            return nuevo.ENCONDING();
        }
       
    }
}
