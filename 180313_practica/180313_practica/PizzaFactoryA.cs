﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180313_actividad
{
    class PizzaFactoryA:Factory
    {
        public override IPizza OrderPizza(String PizzaType, string tamaño)
        {
            switch (PizzaType)
            {
                case "Mexicana":

                    Console.Write("Hecha en la PIZZA FACTORY A ");
                    // return new Mexicana(tamaño);
                    var M = new Mexicana(tamaño);
                    var cor = new Corteza(M);
                    var to = new Tocino(cor);
                    var que = new Queso(to);
                    var ja = new Jamon(que);
                    ja.ImprimirInfo();
                    break;
                case "Hawaiana":
                
                    Console.Write("Hecha en la PIZZA FACTORY B ");
                    // return new Mexicana(tamaño);
                    var H = new Hawaiana(tamaño);
                    var Hc = new Corteza(H);
                    var Hj = new Jamon(Hc);
                    var Hp = new Piña(Hj);

                    Hp.ImprimirInfo();
                    break;
                case "Peperoni":
                    Console.Write("Hecha en la PIZZA FACTORY A ");
                    // return new Mexicana(tamaño);
                    var p = new Peperoni(tamaño);
                    var cort = new Corteza(p);
                    var pe = new PeperoniCortado(cort);
                    var ques = new Queso(pe);

                    ques.ImprimirInfo();
                    break;

                default:
                    return null;
                    break;
            }


            return null;
        }
    }
    }


