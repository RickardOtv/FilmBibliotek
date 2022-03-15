using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio
{
    partial class Program
    {
        // Avslutar programet
        public static bool Quit()
        {
            string stop;

            while (true)
            {
                Console.Write("Vill du avsluta?  (Y/N)   : ");
                stop = Console.ReadLine().ToLower();
                if (stop == "y")
                {
                    Console.WriteLine("ZzZzZzZ");
                    Console.ReadLine();
                    return false;
                }
                else if (stop == "n")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Försök igen");
                }
            }
        }
    }
}