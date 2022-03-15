using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bio
{
    partial class Program
    {
        // Funktionen tar bort en utvald film ifall hittad
        public static void DeleteMovie()
        {
            Console.WriteLine("\n");
            Console.Write("Ange title: ");
            string title = Console.ReadLine();
            Movie[] m = SearchMoviesByTitle(title);
            if (m == null)
            {
                Console.WriteLine("Film med dena title finns inte!");
                return;
            }
            Movie movie = m[0];   // Ifall film man vill ta bort men den inte finns med så funkar det inte
            RemoveMovie(movie);
            Console.WriteLine("\n");
        }

        // Letar upp en film i movies arrayen för att hitta index
        public static void RemoveMovie(Movie b)
        {
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i] == b)
                {
                    RemoveFromMovies(i);
                    return;
                }
            }
        }

        // Skapar en ny array där en vald film på en index är bort tagen
        public static void RemoveFromMovies(int index)
        {
            Movie[] temp = new Movie[movies.Length - 1];

            for (int i = 0; i < index; i++)
            {
                temp[i] = movies[i];
            }
            for (int i = index + 1; i < movies.Length; i++)
            {
                temp[i - 1] = movies[i];
            }
            movies = temp;
        }

    }
}