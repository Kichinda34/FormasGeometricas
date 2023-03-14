using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea
{
    internal class Triangulo : FormaGeometrica
    {
        public override double CalcularArea()
        {
            return base.CalcularArea() / 2;
        }
    }
}
