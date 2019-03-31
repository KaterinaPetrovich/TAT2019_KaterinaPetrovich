using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{
    class Bird : FlyingObject, IFlyable
    {
        /// <summary>
        /// returns what is it
        /// </summary>
        /// <returns>name of flying object</returns>
        public string WhoAmI()
        {
            return "I am Bird";
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
            Random rnd = new Random();
            speed = rnd.Next(0, 20);
            if (speed == 0)
            {
                return 0;
            }
            time = distance / speed;
            return time;
        }
    }
}
