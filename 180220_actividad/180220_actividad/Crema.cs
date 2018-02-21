﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180220_actividad
{
    class Crema:AbstractIngrediente
    {
        public int precio=10;
        AbstractBebida Bebida;
        private string descripccion = " un chorro de crema ";
        public Crema(AbstractBebida bebida)
        {
            Bebida = bebida;

        }
        public override int Costo()
        {
            precio = precio + Bebida.Costo();
            return precio;
        }
        public override string GetDescripcion()
        {

            return Bebida.GetDescripcion() + descripccion;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Descripcion: " + GetDescripcion() + "\n Total: " + Costo());
        }
    }
}
