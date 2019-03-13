using System;

namespace ConsoleApp1
{
    /// <summary>
    /// Entry point
    /// </summary>
    class Entrypoint
    {
        static void Main(string[] args)
        {                      
            SearchAndDisplay Object = new SearchAndDisplay(args);
            for (int i = 0; i < args.Length; i++)
            {              
                string outputLine = args[i];                          
                Object.OutputSubstring(outputLine);
            }
        }
    }
}
