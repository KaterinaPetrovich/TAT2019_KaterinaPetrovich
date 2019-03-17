using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Entry point of program
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0||args[0].Length<2)
                    throw new FormatException();

                int[] matrix;
                int stress = 0;
                string word = args[0];
                Word Object = new Word();
                string line = Object.SearchStress(word, out stress);
                matrix = Object.check(line);
                Object.fonemaBuild(line, matrix, stress);
            }
            catch(FormatException)
            {
                Console.WriteLine("Please input word");              
            }
        }
    }
}
