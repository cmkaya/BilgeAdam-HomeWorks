using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDemo3.GeometricShapes.Interfaces;

namespace InterfacesDemo3.GeometricShapes
{
    class StraightTriangle : ITriangle
    {
        public double FirstEdge { get; set; }
        public double SecondEdge { get; set; }
        public double BaseEdge { get; set; }
        public double CalculateField()
        {
            double field;
            return field = FirstEdge * SecondEdge / 2;
        }

        public double CalculatePerimeter()
        {
            double perimeter;
            return perimeter = FirstEdge + SecondEdge + BaseEdge;
        }
    }
}
