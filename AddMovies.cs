using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio
{
    partial class Program
    {
        public static void NewMovie()
        {
            Console.WriteLine("\n");
            Console.Write("Ange title: ");
            string title = Console.ReadLine();
            Console.Write("Ange genre: ");
            string genre = Console.ReadLine();
            Console.Write("Ange director: ");
            string director = Console.ReadLine();
            Console.Write("Ange film längd: ");
            double length = Double.Parse(Console.ReadLine()); // Fixa ifall så att det bara går att skriva num
            Console.Write("Ange när film släptes: ");
            string releaseDate = Console.ReadLine();

            Movie m = CreateMovie(title, genre, director, length, releaseDate);
            movies = AddMoviesToArray(movies, m);
            Console.WriteLine("\n");
        }


        /// Tar emot en klar ny bil och lägger till den i bil listan
        public static Movie[] AddMoviesToArray(Movie[] oldMovies, Movie newMovie)
        {
            Movie[] newMovies = new Movie[oldMovies.Length + 1];

            for (int i = 0; i < oldMovies.Length; i++)
            {
                newMovies[i] = oldMovies[i];
            }
            newMovies[oldMovies.Length] = newMovie;

            return newMovies;
        }
    }
}