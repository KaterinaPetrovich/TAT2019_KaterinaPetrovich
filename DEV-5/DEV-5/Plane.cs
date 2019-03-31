using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{
    /// <summary>
    /// determines object plane and propeties of this object
    /// </summary>
    class Plane : FlyingObject, IFlyable
    {
        /// <summary>
        /// constructor assign start speed
        /// </summary>
        public Plane()
        {
            speed = 200;
        }

        /// <summary>
        /// returns what is it
        /// </summary>
        /// <returns>name of flying object</returns>
        public string WhoAmI()
        {
            return "I am Plane";
        }

        /// <summary>
        /// assign target point
        /// </summary>
        /// <param name="newPoint">target point</param>
        public void FlyTo(Point newPoint)
        {
            targetPoint = newPoint;
        }

        /// <summary>
        /// calculate flight time
        /// </summary>
        /// <returns> time of flight</returns>
        public double GetFlyTime()
        {
            time = 0;
            this.CalculateDistance();
            while (distance >= 10)
            {
                time += 10.0 / speed;
                speed += 10;
                distance -= 10;
            }
            time += distance / speed;
            return time;
        }
    }
}
