using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Triangle
{
    /// <summary>
    /// Class triangle describes Equilateral Triangle and worcs with points
    /// </summary>
    class TriangleEquilateral : Triangle
    {
        double length12;
        double length23;
        double length13;

        /// <summary>
        /// Constructor for definition points
        /// </summary>
        /// <param name="point1">first treagle's point</param>
        /// <param name="point2">second treagle's point</param>
        /// <param name="point3">third treagle's point</param>
        public TriangleEquilateral(Point _point1, Point _point2, Point _point3) : base( _point1,  _point2,  _point3)
        {
        }

        /// <summary>
        /// Method for calculate square for Equilateral Triangle
        /// </summary>
        /// <returns> Return square</returns>
        public override double GetSquare()
        {
            length12 = point1.GetLength(point2);
            length23 = point2.GetLength(point3);
            length13 = point1.GetLength(point3);

            if((length12> length23)&&(length12> length13))
            {
                return length23 * length13 / 2;
            }
            else
            {
                return 0;
            }

        }
    }
}
