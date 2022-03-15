using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio
{
    partial class Program
    {
        public static int PrintMenu()
        {
            Console.WriteLine("1. Lista alla filmer");
            Console.WriteLine("2. Lista filmer på title");
            Console.WriteLine("3. Lista filmer på genre");
            Console.WriteLine("4. Lista filmer på director");
            Console.WriteLine("5. Lista filmer på längd");
            Console.WriteLine("6. Sortera lista på title");
            Console.WriteLine("7. Sortera lista på film längd");
            Console.WriteLine("8. Lägg till film");
            Console.WriteLine("9. Ta bort film");
            Console.WriteLine("0  Spara och avsluta");
            Console.Write("Ange menyval: ");

            string menyval = Console.ReadLine();
            int val;
            while (!int.TryParse(menyval, out val))
            {
                Console.Write("Ange menyval: ");
                menyval = Console.ReadLine();
            }

            return val;
        }
    }

}