﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Entry point of program
    /// </summary>
    public class EntryPoint
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
<<<<<<< HEAD
                if (Object.SearchAndDeleteStress(word, out stress) != null)
                {
                    string line = Object.SearchAndDeleteStress(word, out stress);
=======
                if (Object.SearchStress(word, out stress) != null)
                {
                    string line = Object.SearchStress(word, out stress);
>>>>>>> a5529a7ae263e2d32c6aaa421e7bb75135bdc880
                    matrix = Object.Сheck(line);
                    string fonema=Object.FonemaBuild(line, matrix, stress);
                    Object.fonemaPrint(fonema);
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Please input word");              
            }
        }
    }
}
