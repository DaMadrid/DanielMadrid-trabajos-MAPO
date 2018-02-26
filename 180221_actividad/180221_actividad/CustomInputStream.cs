using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180221_actividad
{
  public  class LowerInputStream : System.IO.StreamReader
    {
        public LowerInputStream(Stream stream) : base(stream) { }
        public override int Read()
        {
            int c = base.Read();
            if (c == 1)
            {
                return -1;
            }
            else
            {
                return char.ToLower((char)c);
            }
        }
    }
}
