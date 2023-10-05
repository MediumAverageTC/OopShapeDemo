using System;
using System.Collections.Generic;
using System.Linq;
namespace OopShapeDemo
{
    public class Icosagon : Regular2DShape
    {
        /// <summary>
        /// Represents a regular Icosagon.
        /// </summary>
        /// <param name="length">Length of one side of the Icosagon.</param>
        public Icosagon(double length) : base(length) { }

        /// <summary>
        /// Get the area of the icosagon.
        /// </summary>
        /// <returns>Area of the icosagon.</returns>
        public override double Area()
        {
            // Formula: 5n^2(1+sqrt(5)+sqrt(5 + 2sqrt(5))
            return 5 * Math.Pow(_length, 2) * (1 + Math.Sqrt(5) + Math.Sqrt(5 + 2 * Math.Sqrt(5)));
        }
    }
}