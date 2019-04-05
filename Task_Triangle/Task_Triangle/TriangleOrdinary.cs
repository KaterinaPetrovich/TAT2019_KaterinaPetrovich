using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Triangle
{
    /// <summary>
    /// Class triangle describes Ordinary Triangle and worcs with points
    /// </summary>
    class TriangleOrdinary : Triangle
    {
        /// <summary>
        /// Constructor for definition points
        /// </summary>
        /// <param name="point1">first treagle's point</param>
        /// <param name="point2">second treagle's point</param>
        /// <param name="point3">third treagle's point</param>
        public TriangleOrdinary(Point _point1, Point _point2, Point _point3) : base(_point1, _point2, _point3)
        {
        }

        /// <summary>
        /// Method for calculate square for Just Triangle
        /// </summary>
        /// <returns> Return square</returns>
        public override double GetSquare()
        {
            return (1 / 2) * ((point1.X - point3.X) * (point2.Y - point3.Y) - (point1.Y - point3.Y) * (point2.X - point3.X));
        }
    }
}
