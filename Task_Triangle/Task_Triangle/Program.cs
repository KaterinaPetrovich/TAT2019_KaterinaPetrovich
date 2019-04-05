

using System;

namespace Task_Triangle
{
    /// <summary>
    /// Entry Point. In this program works with Triangle
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();
            Point point2 = new Point();
            Point point3 = new Point();

            point1.X = 1;
            point1.Y = 1;
            point2.X = 2;
            point2.Y = 2;
            point3.X = 3;
            point3.Y = 1;

            BuilderRectangular builderRectangular = new BuilderRectangular(new BuilderEquilateral(new BuilderOrdinary(null)));

            Triangle triangle;
            triangle = builderRectangular.Create(point1,point2,point3);

            Console.WriteLine(triangle.GetSquare());
        }
    }
}
