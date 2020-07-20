using System;
using System.Collections.Generic;
using System.Text;

namespace Lab0
{
    class Rectangle : Shape
    {
        private int width;
        private int height;

        public Rectangle(int width, int height, string id) : base(id)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area
        {
            get
            {
                // Given the width and height, return the area of a rectangle:
                return this.width * this.height;
            }
        }
    }
}
