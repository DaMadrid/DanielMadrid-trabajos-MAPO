using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180403_actividad
{
    class TurkeyDog : IDog
    {
        Turkey miturkey;
        public TurkeyDog(Turkey turkey) {
            this.miturkey = turkey;
        }
        public void Bark()
        {
            miturkey.gobble();
        }

        public void Bite()
        {
            miturkey.peck();
        }
    }
}
