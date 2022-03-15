using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio
{
    partial class Program
    {
        // Funktion för att byta plats på element i en array
        public static void Swap(Movie[] allMovies, int a, int b)
        {
            Movie r = allMovies[a];
            allMovies[a] = allMovies[b];
            allMovies[b] = r;
        }

        // Funktionen sorterar en array filmer i title ordning
        public static void SortByTitle(Movie[] allMovies)
        {
            bool ejSorterad = true;

            int end = allMovies.Length - 1;

            while (ejSorterad)
            {
                ejSorterad = false;
                for (int j = 0; j < end; j++)
                {
                    if (allMovies[j].title.CompareTo(allMovies[j + 1].title) > 0)
                    {
                        Swap(allMovies, j, j + 1);
                        ejSorterad = true;
                    }
                }
                end--;
            }
            Console.WriteLine("\n");
        }

        // Funktionen sorterar en array filmer i film längd ordning
        public static void SortByMovieLength(Movie[] allMovies)
        {
            bool ejSorterad = true;

            int end = allMovies.Length - 1;

            while (ejSorterad)
            {
                ejSorterad = false;
                for (int j = 0; j < end; j++)
                {
                    if (allMovies[j].movieLength.CompareTo(allMovies[j + 1].movieLength) > 0)
                    {
                        Swap(allMovies, j, j + 1);
                        ejSorterad = true;
                    }
                }
                end--;
            }
            Console.WriteLine("\n");
        }
    }
}