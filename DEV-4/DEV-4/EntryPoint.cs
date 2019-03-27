using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    /// <summary>
    /// entry point of class
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject();
            Subject sub1 =(Subject) sub.Clone();
            Lecture lec = new Lecture();
            bool d;
            d= lec.Equals(sub);
            bool l = sub.Equals(sub1);
            if (d)
            {
                Console.WriteLine("jjj");
            }
            if (l)
            {
                Console.WriteLine("jkjkjj");
            }
            Console.WriteLine(sub.GetGuid().ToString());
            Console.WriteLine("jjj");
            Console.WriteLine(lec.GetGuid().ToString());
        }
    }
}
