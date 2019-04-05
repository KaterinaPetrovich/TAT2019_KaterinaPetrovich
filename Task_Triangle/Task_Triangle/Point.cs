using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Triangle
{
    /// <summary>
    /// Structur for describes object point 
    /// </summary>
    struct Point
    {
        double coordX;
        double coordY;

        public double X
        {
            get{ return coordX; }
            set{ coordX = value; }

        }

        public double Y
        {
            get { return coordY; }
            set { coordY = value; }

        }

        /// <summary>
        /// This method calculate Length between two points
        /// </summary>
        /// <param name="point2"></param>
        /// <returns></returns>
        public  double GetLength(Point point2)
        {
            return Math.Sqrt((this.X - point2.X) * (this.X - point2.X) + (this.Y - point2.Y) * (this.Y - point2.Y));
        }

    }
}
