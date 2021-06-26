using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo3.GeometricShapes
{
    interface ITetragon
    {
        double LongSide { get; set; }
        double CalculateField();
        double CalculatePerimeter();
    }
}
