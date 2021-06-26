using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo3.GeometricShapes
{
    class Rectangle : ITetragon
    {
        public double ShortSide { get; set; }
        public double LongSide { get; set; }
        public double CalculateField()
        {
            return ShortSide * LongSide;
        }

        public double CalculatePerimeter()
        {
            return 2 * (ShortSide + LongSide);
        }
    }
}
