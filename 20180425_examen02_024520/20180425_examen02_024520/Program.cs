using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace _20180425_Examen02_024520
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            var cocinar = new Cocinar();
            var repararAuto = new RepararAuto();
            var lavarcarro = new LavarCarro();
            var pintarcasa = new PintarCasas();
            var cocinar1 = new Cocinar();
            var repararAuto1 = new RepararAuto();
            var lavarcarro1 = new LavarCarro();
            var pintarcasa1 = new PintarCasas();
            var robot1 = new Robot("1");
            var robot2= new Robot("2");
            var robot3 = new Robot("3");
            var robot4 = new Robot("4");
            var robot5 = new Robot("5");

            List<IOrdenes> todo = new List<IOrdenes>();
            List<IOrdenes> agarrado = new List<IOrdenes>();
            List<IRobot> robots = new List<IRobot>();
            todo.Add(cocinar);
            todo.Add(repararAuto);
            todo.Add(lavarcarro);
            todo.Add(pintarcasa);
            todo.Add(cocinar1);
            todo.Add(repararAuto1);
            todo.Add(lavarcarro1);
            todo.Add(pintarcasa1);
            robots.Add(robot1);
            robots.Add(robot2);
            robots.Add(robot3);
            robots.Add(robot4);
            robots.Add(robot5);

            Registro registro = new Registro();
            foreach (IOrdenes orden in todo)
            {
             //  registro.EscribirRegistro(orden.getName());
            }
          void agarrar() {
                foreach (IRobot rov in robots)
                {
                    foreach (IOrdenes orden in agarrado)
                {
                   

                        registro.EscribirRegistro(orden.getName());
                        if (!agarrado.Any())
                        {
                            invoker.SetCommand(rov, orden);
                            agarrado.Remove(orden);
                            Parallel.Invoke( () => robot1.Work(), () => robot2.Work(), () => robot3.Work(), () => robot4.Work(), () => robot5.Work());

                        }
                    }
                }
            }
          
                
                agarrar();
            
         
        }

  

     
    }
}
