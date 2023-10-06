using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopShapeDemo
{
    internal class Circle : Regular2DShape
    {
        public Circle(double length) : base(length) { }
        public override double Area()
        {
            return Math.PI * Math.Pow(_length, 2);
        }
    }
}
