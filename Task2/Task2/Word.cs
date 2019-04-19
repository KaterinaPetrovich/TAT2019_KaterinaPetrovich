using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Word
    {
        string ordinaryvowels = "аыуэ";
        string compositevowels = "еяиёю";
        string ringing = "бвгджз";
        string deaf = "пфктшс";
        string alwaysdeaf = "хщцч";
        string symbol = "ьъ";  
        Dictionary<char, char> fromRingingToDeaf = new Dictionary<char, char>
        {
            ['б'] = 'п',
            ['в'] = 'ф',
            ['г'] = 'к',
            ['д'] = 'т',
            ['ж'] = 'ш',
            ['з'] = 'с',
        };
        Dictionary<char, char> fromDeafToRinging = new Dictionary<char, char>
        {
            ['п'] = 'б',
            ['ф'] = 'в',
            ['к'] = 'г',
            ['т'] = 'д',
            ['ш'] = 'ж',
            ['с'] = 'з',
        };
        Dictionary<char, string> compositeVowelsPairs = new Dictionary<char, string>
        {
            ['я'] = "йа",
            ['е'] = "йэ",
            ['ё'] = "йо",
            ['ю'] = "йу",
            ['и'] = "йы",

        };
        Dictionary<char, string> softness = new Dictionary<char, string>
        {
            ['я'] = "'а",
            ['е'] = "'э",
            ['и'] = "'ы",
            ['ё'] = "'о",
            ['ю'] = "'у",

        };
        /// <summary>
        /// This method checks type of letters of word
        /// </summary>
        /// <param name="word"> inputed string</param>
        /// <returns></returns>
        public int[] Сheck(string word)
        {           
            int[] matrix = new int[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                if (checkOrdinaryVowels(word[i]))
                {
                    matrix[i] = 1;
                }
                else
                    if (checkCompositeVowels(word[i]))
                {
                    matrix[i] = 2;
                }
                else
                    if (checkO(word[i]))
                {
                    matrix[i] = 3;
                }
                else
                    if (checkRinging(word[i]))
                {
                    matrix[i] = 4;
                }
                else
                    if (checkDeaf(word[i]))
                {
                    matrix[i] = 5;
                }
                else
                    if (checkAlwaysDeaf(word[i]))
                {
                    matrix[i] = 6;
                }
                else
                    if (checkSymbol(word[i]))
                {
                    matrix[i] = 7;
                }
                else
                    matrix[i] = 0;
            }
            return matrix;           
        }
        public bool checkOrdinaryVowels(char c)
        {
            return ordinaryvowels.Contains(c);
        }
        public bool checkCompositeVowels(char c)
        {
            return compositevowels.Contains(c);
        }
        public bool checkRinging(char c)
        {
            return ringing.Contains(c);
        }

        public bool checkDeaf(char c)
        {
            return deaf.Contains(c);
        }

        public bool checkAlwaysDeaf(char c)
        {
            return alwaysdeaf.Contains(c);
        }

        public bool checkSymbol(char c)
        {
            return symbol.Contains(c);
        }

        public bool checkO(char c)
        {
            return (c == 'о');
        }
        /// <summary>
        /// this method build fonema
        /// </summary>
        /// <param name="word">inputed string</param>
        /// <param name="matrix">matrix with codes of elements</param>
        /// <param name="stress">index of stressed letter</param>
        public string FonemaBuild(string word, int[] matrix, int stress)
        {
            string fonema = String.Empty;
            for(int i=0; i<matrix.Length; i++)
            {
                switch (matrix[i])
                {
                    case 0:
                        fonema = fonema + word[i];
                        break;
                    case 1:
                        fonema = fonema + word[i];
                        break;
                    case 2:
                        if (i == 0 || (matrix[i - 1] == 3) || (matrix[i - 1] == 2) || (matrix[i - 1] == 1) || (matrix[i - 1] == 7))
                        {
                            fonema = fonema + compositeVowelsPairs[word[i]];
                        }
                        else if ((matrix[i - 1] == 4) || (matrix[i - 1] == 5) || (matrix[i - 1] == 6) || (matrix[i - 1] == 0))
                        {
                            fonema = fonema + softness[word[i]];
                        }
                        else
                            fonema = fonema + word[i];
                        break;
                    case 3:
                        if(i!=stress)
                        {
                            fonema = fonema + 'a';
                        }
                        else
                            fonema = fonema + word[i];
                        break;
                    case 4:
                        if(i==word.Length-1 || matrix[i+1]==5|| matrix[i+1]==6)
                        {
                            fonema = fonema + fromRingingToDeaf[word[i]];
                        }
                        else
                            fonema = fonema + word[i];
                        break;
                    case 5:
                        if(i == word.Length - 1)
                            fonema = fonema + word[i];
                        else if ((matrix[i+1]==4)&&(word[i+1]!='в'))
                        {
                            fonema = fonema + fromDeafToRinging[word[i]];
                        }
                        else
                            fonema = fonema + word[i];
                        break;
                    case 6:
                        fonema = fonema + word[i];
                        break;
                    case 7:
                        fonema = fonema + "'";
                        break;
                }
            }
            return fonema;
        }
        /// <summary>
        /// this method adds plus if word does not have plus
        /// </summary>
        /// <param name="word">inputed string</param>
        /// <returns>word with added plus</returns>
        public string AddPlus(string word)
        {
            int[] matrix;
            matrix = Сheck(word);
            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i] == 1 || matrix[i] == 2 || matrix[i] == 3)
                {
                    word = word.Insert(i + 1, "+");
                }
            }
            return word;
        }
        /// <summary>
        /// this method searches stressed letter and remove '+'
        /// </summary>
        /// <param name="word">inputed string</param>
        /// <param name="stress">index of stressed letter</param>
        /// <returns>word with deleted '+'</returns>
        public string SearchStress(string word, out int stress)
        {
           
            // Search stress and remove symbol '+' from word.
            if (word.Contains('+'))
            {
                stress = word.IndexOf('+') - 1;
                word = word.Remove(word.IndexOf('+'), 1);
                return word;
            }
            else if (word.Contains('ё'))
            {
                stress = word.IndexOf('ё') -1;
                word = word.Remove(word.IndexOf('+'), 1);
                return word;
            }
            else
            {
                try
                {
                    if (CheckWordForOneSyllable(word))
                    {
                        word = AddPlus(word);
                        stress = word.IndexOf('+') - 1;
                        word = word.Remove(word.IndexOf('+'), 1);
                        return word;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("Please add stress");
                    stress = 0;
                    return null;
                }
            }
            
        } 

        /// <summary>
        /// prints fonema
        /// </summary>
        /// <param name="fonema">needed string</param>
        public void fonemaPrint(string fonema)
        {
            Console.WriteLine(fonema);
        }

        //public bool CheckWordForStress(string word)
        //{
        //    if (word.Contains('+')||word.Contains('ё'))
        //
        //}
        public bool CheckWordForOneSyllable(string word)
        {
            int[] matrix;
            matrix = Сheck(word);
            int syllableCounter = 0;
            foreach( int number in matrix)
            {
                if (number == 1 || number == 2 || number == 3)
                {
                    syllableCounter = syllableCounter + 1;
                }
            }
            return (syllableCounter == 1);
        }

    }     
}
