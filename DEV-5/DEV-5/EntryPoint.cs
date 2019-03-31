using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{
    /// <summary>
    /// Calculate time of flight for different flying objects
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// entry point of program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            SpaceShip spaceShip = new SpaceShip();
            Plane plane = new Plane();
            Point point = new Point();
            point.SetPoint(100,200,800);

            bird.FlyTo(point);
            Console.WriteLine(bird.GetFlyTime().ToString());
            Console.WriteLine(bird.WhoAmI());

            spaceShip.FlyTo(point);
            Console.WriteLine(spaceShip.GetFlyTime().ToString());
            Console.WriteLine(spaceShip.WhoAmI());

            plane.FlyTo(point);
            Console.WriteLine(plane.GetFlyTime().ToString());
            Console.WriteLine(plane.WhoAmI());
        }
    }
}
