using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{
    /// <summary>
    /// determinates point
    /// </summary>
    struct Point
    {
        int coordinateX;
        int coordinateY;
        int coordinateZ;

        /// <summary>
        /// method to assign point
        /// </summary>
        /// <param name="x">coordinate x</param>
        /// <param name="y">coordinate y</param>
        /// <param name="z">coordinate z</param>
        public void SetPoint(int x, int y, int z)
        {
            coordinateX = x;
            coordinateY = y;
            coordinateZ = z;
        }

        public int CoordinateX
        {
            get { return coordinateX; }
            set { coordinateX = value; }
        }

        public int CoordinateY
        {
            get { return coordinateY; }
            set { coordinateY = value; }
        }

        public int CoordinateZ
        {
            get { return coordinateZ; }
            set { coordinateZ = value; }
        }
    }
}
