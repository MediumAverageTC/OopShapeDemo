using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopShapeDemo
{
    public class Hexagon : Regular2DShape
    {
        public Hexagon(double length) : base(length) { }

        public override double Area()
        {
            return ((3 * Math.Sqrt(3)) / 2) * Math.Pow(_length, 2);
        }
    }
}
