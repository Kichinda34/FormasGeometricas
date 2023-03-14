using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea
{
    internal abstract class FormaGeometrica
    {
        public int ladoA { get; set; }

        public int ladoB { get; set; }

        public FormaGeometrica()
        {
            
        }

        public virtual double CalcularArea()
        {
            return ladoA * ladoB;
        }

        public override string ToString()
        {
            return this.ladoB + " " + ladoA;
        }

    }
}
