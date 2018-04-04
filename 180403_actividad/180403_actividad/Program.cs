using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180403_actividad
{
    class Program
    {
        static void Main(string[] args)
        {
            var gato = new Gato();
            var turkey= new Turkey();
            var fakedog = new CatDog( gato);
            fakedog.Bark();
            fakedog.Bite();
            var fakedog2 = new TurkeyDog(turkey);
            fakedog2.Bark();
            fakedog2.Bite();
        }
    }
}
