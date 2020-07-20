using System;
using System.Collections.Generic;
using System.Text;

namespace Lab0
{
    class Circle : Shape
    {
        private int radius;

        public Circle(int radius, string id) : base(id)
        {
            this.radius = radius;
        }

        public override double Area
        {
            get
            {
                // Given the radius, return the area of a circle:
                return Math.PI * radius * radius;
            }
        }
    }
}
