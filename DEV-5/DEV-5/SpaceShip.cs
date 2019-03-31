using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{
    class SpaceShip : FlyingObject, IFlyable
    {
        /// <summary>
        /// assigns speed
        /// </summary>
        public SpaceShip()
        {
            speed = 28800000;
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
            this.CalculateDistance();
            time = distance / speed;
            return time;
        }

        /// <summary>
        /// returns what is it
        /// </summary>
        /// <returns>name of flying object</returns>
        public string WhoAmI()
        {
            return "I am space ship";
        }
    }
}
