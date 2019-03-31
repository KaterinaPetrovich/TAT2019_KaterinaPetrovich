using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{
    /// <summary>
    /// base class for classes of flying objects
    /// </summary>
     abstract class FlyingObject
     {
        protected int speed;
        protected Point targetPoint;
        protected Point startPoint;
        protected double distance;
        protected double time;

        /// <summary>
        /// constructor assign default values for points
        /// </summary>
        public FlyingObject()
        {
            startPoint.SetPoint(0, 0, 0);
            targetPoint.SetPoint(0, 0, 0);
        }

        /// <summary>
        /// calculates distance between start point and target point
        /// </summary>
        public void CalculateDistance()
        {
            distance =Math.Sqrt((targetPoint.CoordinateX - startPoint.CoordinateX)^2+ (targetPoint.CoordinateY - startPoint.CoordinateY)^2+ (targetPoint.CoordinateZ - startPoint.CoordinateZ)^2);
        }
        
     }
}
