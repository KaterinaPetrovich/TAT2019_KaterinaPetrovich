using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{
    /// <summary>
    /// assign methods which implement in inherited classes
    /// </summary>
    interface IFlyable
    {
        /// <summary>
        /// assign target point
        /// </summary>
        /// <param name="newPoint">target point</param>
        void FlyTo(Point newPoint);

        /// <summary>
        /// returns what is it
        /// </summary>
        /// <returns>name of flying object</returns>
        string WhoAmI();

        /// <summary>
        /// calculate flight time
        /// </summary>
        /// <returns> time of flight</returns>
        double GetFlyTime();
    }
}
