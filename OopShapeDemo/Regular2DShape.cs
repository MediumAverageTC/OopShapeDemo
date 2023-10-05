using System;

namespace OopShapeDemo
{
    public abstract class Regular2DShape
    {
        protected double _length; // Length of one side of the shape.

        /// <summary>
        /// Length of one side of the shape.
        /// </summary>
        public double Length
        {
            get { return _length; }
            private set { }
        }

        /// <summary>
        /// Represents a regular 2d shape.
        /// </summary>
        /// <param name="length">Length of one side of the shape.</param>
        /// <exception cref="ArgumentException">Thrown if arguement "length" is not positive.</exception>
        public Regular2DShape(double length)
        {
            if (length <= 0)
                throw new ArgumentException("Arguement \"length\" must be positive.");
            
            this._length = length;
        }

        /// <summary>
        /// Get the area of the shape.
        /// </summary>
        /// <returns>Area of the shape.</returns>
        public abstract double Area();
    }
}