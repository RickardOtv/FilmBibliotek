using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bio
{
    partial class Program
    {

        public static void FindByTitle()
        {
            Console.Write("Ange title: ");
            string searchPhrase = Console.ReadLine();
            Movie[] foundMovies = SearchMoviesByTitle(searchPhrase);
            Program.PrintMovies(foundMovies);
        }

        // Function för att söka efter film via title
        public static Movie[] SearchMoviesByTitle(string searchPhrase)
        {
            // Skapar en tom Array
            Movie[] hittadeFilmer = new Movie[0];

            // For - loop för att gå igenom arrayen
            for (int i = 0; i < Program.movies.Length; i++)
            {
                // Om searchPrase Stämmer så läggs den till i den nya listan
                if (Program.movies[i].title.ToUpper().Contains(searchPhrase.ToUpper()))
                {
                    hittadeFilmer = Program.AddMoviesToArray(hittadeFilmer, Program.movies[i]);
                }
            }
            return hittadeFilmer;
        }


        public static void FindByDirector()
        {
            Console.Write("Ange direktör namn: ");
            string searchPhrase = Console.ReadLine();
            Movie[] foundMovies = SearchMoviesByDirector(searchPhrase);
            Program.PrintMovies(foundMovies);
        }

        // Function för att söka efter film via direktör
        public static Movie[] SearchMoviesByDirector(string searchPhrase)
        {
            // Först skapar vi en vektor med samma längd som den 
            // fullständiga boklistan
            Movie[] foundMovies = new Movie[Program.movies.Length];
            int numberOfBooks = 0;

            // Sedan itererar vi igenom listan
            for (int i = 0; i < Program.movies.Length; i++)
            {
                // Om titeln stämmer med sökordet, lägger vi den boken
                // i nästa lediga plats i den nya vektorn
                if (Program.movies[i].director.ToUpper().Contains(searchPhrase.ToUpper()))
                {
                    foundMovies[numberOfBooks++] = Program.movies[i];
                }
            }

            // Nu skapar vi en ny vektor, med rätt längd, till vilken vi 
            // för över de funna böckerna
            Movie[] foundMoviesTrimmed = new Movie[numberOfBooks];

            for (int i = 0; i < numberOfBooks; i++)
            {
                foundMoviesTrimmed[i] = foundMovies[i];
            }
            return foundMoviesTrimmed;
        }
    }
}