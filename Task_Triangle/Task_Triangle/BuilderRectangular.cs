

namespace Task_Triangle
{
    /// <summary>
    /// Calass for building triagle
    /// </summary>
    class BuilderRectangular : Builder
    {
        double length12;
        double length23;
        double length13;

        public BuilderRectangular(Builder builder) : base(builder)
        {
        }

        /// <summary>
        /// Method for definition triagle and create rectangular triangle
        /// </summary>
        /// <param name="point1">first treagle's point</param>
        /// <param name="point2">second treagle's point</param>
        /// <param name="point3">third treagle's point</param>
        /// <returns>Return rectangular triangle</returns>
        public override Triangle Create(Point point1, Point point2, Point point3)
        {
            length12 = point1.GetLength(point2);
            length23 = point2.GetLength(point3);
            length13 = point1.GetLength(point3);

            if ((length12* length12== length23* length13)||(length23* length23== length12* length13)|| (length13* length13== length23* length12))
            {
                TriangleRectangular triangleRectangular = new TriangleRectangular(point1,point2,point3);
                return triangleRectangular;
            }
            else
            {
                return builder.Create(point1, point2, point3);
            }

        }
    }
}
