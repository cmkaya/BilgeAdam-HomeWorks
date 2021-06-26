using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo3.GeometricShapes
{
    class Square : ITetragon
    {
        public double LongSide { get; set; }
        public double CalculateField()
        {
            return Math.Pow(LongSide, 2);
        }

        public double CalculatePerimeter()
        {
            return LongSide * 4;
        }
    }
}
