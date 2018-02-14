using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180213_practica
{
    class paquete
    {
        public int Id;
        public string Direccion;
        public string Nombre;
        public int Peso;
        public double distancia;
        public string proveedor;
        public int ClienteID;


        public paquete(int id,int CId ,string dir, string nombre, int peso, double distancia,string prov)
        {
            this.Id = id;
            this.Direccion = dir;
            this.Nombre = nombre;
            this.ClienteID = CId;
            this.Peso = peso;
            this.distancia = distancia;
            this.proveedor = prov;
        }
        public int id
        { get { return this.Id; } }
        public String dir
        { get { return this.Direccion; } }
        public string nom
        { get { return this.Nombre; } }
        public int pes
        { get { return this.Peso; } }
        public Double dist
        { get { return this.distancia; } }
        public String pro
        { get { return this.proveedor; } }

    }
}
