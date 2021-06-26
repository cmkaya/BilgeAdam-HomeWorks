using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDemo3.GeometricShapes.Interfaces;

namespace InterfacesDemo3.GeometricShapes
{
    class EquilateralTriangle : ITriangle
    {
        public double BaseEdge { get; set; }
        public double CalculateField()
        {
            double field = (Math.Sqrt(3) / 4) * Math.Pow(BaseEdge, 2);
            return Math.Round(field, 2);
        }

        public double CalculatePerimeter()
        {
            double perimeter;
            return perimeter = 3 * BaseEdge;
        }
    }
}
