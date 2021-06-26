using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo3.GeometricShapes
{
    class Circle
    {
        public double Radius { get; set; }

        public double CalculateField()
        {
            double result;
            result = Math.Round((2 * Radius * Math.PI),2);
            return result;
        }

        public double CalculatePerimeter()
        {
            double result;
            result = Math.PI * Math.Pow(Radius, 2);
            return Math.Round(result, 2);
        }
    }
}
