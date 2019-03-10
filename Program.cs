using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {                      
            Search Object = new Search();
            for (int m = 0; m < args.Length; m++)
            {              
                string outputLine = args[m];                
                if (outputLine.Length < 3)
                    Console.WriteLine("Неподходящая строка");               
                Object.OutputSubstring(outputLine);
            }
        }
    }
}
