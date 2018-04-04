using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180403_actividad
{
    class CatDog : IDog
    {
        
        Gato migato;
            
        public CatDog(Gato gato)
        {
            this.migato = gato;
        
        }
        public void Bark()
        {
           
            migato.purr();  
        }

        public void Bite()
        {
            migato.slash();
          
        }
    }
}
