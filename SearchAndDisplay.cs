using System;

namespace ConsoleApp1
{
    class SearchAndDisplay
    {
        /// <summary>
        ///  This constructor checks string on length
        /// </summary>
        /// <param name="inputstrings"> inputed array of strings</param>
        public SearchAndDisplay(string [] inputstrings)
        {
            try
            {
                if (inputstrings.Length == 0)
                {
                    throw new FormatException();
                }

                for (int i = 0; i < inputstrings.Length; i++)
                {
                    string outputLine = inputstrings[i];
                    if (outputLine.Length < 3)
                    {
                        throw new FormatException();
                    }
                       
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error! ");
            }
        }
        /// <summary>
        /// This method prints needed substrings after check
        /// </summary>
        /// <param name="line"> one string from array</param>
        public void OutputSubstring(string line)
        {
            for (int i = 0; i < line.Length - 1; i++)
            {
                for (int j = line.Length - i; j > 1; j--)
                {
                    string templine = line.Substring(i, j);
                    if (Check(templine) == true)
                        Console.WriteLine(templine);
                }
            }
        }
        /// <summary>
        /// This method check substrings on double letters
        /// </summary>
        /// <param name="line">one string from array</param>
        /// <returns> return true if string is without double letters </returns>
        public bool Check(string line)
        {
            bool checkmark = true;
            for (int n = 0; n < line.Length-1; n++)
            {
                if (line[n] == line[n + 1])
                {
                    checkmark = false;
                    break;
                }
            }
            return checkmark;
        }          
    }
}
