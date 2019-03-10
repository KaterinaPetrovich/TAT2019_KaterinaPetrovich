using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Search
    {
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
