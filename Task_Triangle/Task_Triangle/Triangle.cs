

namespace Task_Triangle
{
    /// <summary>
    /// Abstract class triangle describes triange and worcs with points
    /// </summary>
    abstract class Triangle
    {
        protected Point point1;
        protected Point point2;
        protected Point point3;

        /// <summary>
        /// Constructor for definition points
        /// </summary>
        /// <param name="point1">first treagle's point</param>
        /// <param name="point2">second treagle's point</param>
        /// <param name="point3">third treagle's point</param>
        public Triangle(Point _point1,Point _point2, Point _point3)
        {
            point1 = _point1;
            point2 = _point2;
            point3 = _point3;
        }

        /// <summary>
        /// method for calculate square
        /// </summary>
        /// <returns></returns>
        abstract public double GetSquare();     
    }
}
