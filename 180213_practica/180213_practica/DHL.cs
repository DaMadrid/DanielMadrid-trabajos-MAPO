using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _180213_practica
{
    class DHL: ISujeto
    {
        int Id;
        private static Random r = new Random();
        public List<IObservador> subscriptores = new List<IObservador>();
        public List<paquete> Ordenes = new List<paquete>();

        Timer timer;
       
        public DHL() {

            timer = new Timer(5000); 
            timer.Start();
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
           
            MesurementChange();
           // throw new NotImplementedException();
        }


        public void Orden(int Cid, string dir, string nombre, int peso,string prov) {
            Id = r.Next(111, 3333);
            int dis = r.Next(2222,3333) ;
            Ordenes.Add(new paquete(Id,Cid, dir, nombre, peso, dis, "DHL"));
            
        }
      
        public void Remove(IObservador removido)
        {
            subscriptores.Remove(removido);
        }
        public void Register(IObservador registro)
        {
            subscriptores.Add(registro);
        }
        public void Notify()
        {
            foreach (IObservador subscriptor in subscriptores)
            {
                foreach (paquete paq in Ordenes) {
                    if (subscriptor.getId()==paq.ClienteID) {
                        subscriptor.Update(paq);
                    }
                }
            }
        }
        public void MesurementChange()
        {

            foreach (paquete paq in Ordenes) {
                if (paq.distancia > 0)
                {
                    paq.distancia = paq.distancia - 10;
                }
                else{ Ordenes.Remove(paq); }
            }
                        
            Notify();
        }
    }
}
