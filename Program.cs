using System;

namespace Lab0
{
    class Program
    {
        public static void Main()
        {
            Shape[] shapeArray =
                {
                    new Square(5, "Square #1"),
                    new Rectangle(3, 5, "Rectangle #2"),
                    new Circle(7, "Circle #3")
                };

            System.Console.WriteLine("Shapes Collection");
            foreach (Shape s in shapeArray)
            {
                System.Console.WriteLine(s);
                System.Console.WriteLine("Its area = {0}", s.Area);
            }

        }
    }


}
