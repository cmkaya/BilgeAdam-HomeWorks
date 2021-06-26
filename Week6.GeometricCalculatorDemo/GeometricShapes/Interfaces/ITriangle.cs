using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo3.GeometricShapes.Interfaces
{
    interface ITriangle
    {
        double BaseEdge { get; set;  }
        double CalculateField();
        double CalculatePerimeter();
    }
}
