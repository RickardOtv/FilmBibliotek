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
        // Gör en tom array för filmer
        static Movie[] movies = new Movie[0];

        public static void Main()
        {
            LoadMovies();
            MenuChoice();
            SaveMovies();
        }

        // Funktion för användare att göra val
        public static void MenuChoice()
        {
            int val;
            bool keepGoing = true;
            while (keepGoing)
            {
                // Tar emot användarens val
                val = PrintMenu();

                switch (val)
                {
                    case 1:
                        // Skriver ut alla filmer
                        PrintMovies(movies);
                        break;
                    case 2:
                        // Hitta film med title
                        FindByTitle();
                        break;
                    case 3:
                        // Hitta film via genre !!!

                        break;
                    case 4:
                        // Hitta film via direktör !!!
                        FindByDirector();
                        break;
                    case 5:
                        // Hitta film med film längd

                        break;
                    case 6:
                        // Sortera filmer efter title
                        SortByTitle(movies);
                        break;
                    case 7:
                        // Sortera filmer med film längd
                        SortByMovieLength(movies);
                        break;
                    case 8:
                        // Lägg till Film
                        NewMovie();
                        break;
                    case 9:
                        // Ta bort Film
                        DeleteMovie();
                        break;
                    case 0:
                        // Quit
                        keepGoing = Quit();
                        break;
                }
            }
        }




        // Skriver ut filmer ur txt dokument till en array
        public static void LoadMovies()
        {
            StreamReader infil = new StreamReader("movies.txt", Encoding.GetEncoding(28591));

            while (true)
            {
                string line = infil.ReadLine();
                if (line == null) break;

                string[] parts = line.Split('\t');

                Movie m = new Movie();
                string[] fält = line.Split('\t');
                m.title = fält[0];
                m.genre = fält[1];
                m.director = fält[2];
                m.movieLength = double.Parse(fält[3]);
                m.releaseDate = fält[4];

                movies = AddMoviesToArray(movies, m);
            }
            infil.Close();
        }


        // Sparar en array med filmer till ett txt dokument
        public static void SaveMovies()
        {
            StreamWriter utfil = new StreamWriter("movies.txt", false, Encoding.GetEncoding(28591));

            for (int i = 0; i < movies.Length; i++)
            {
                Movie m = movies[i];
                utfil.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",
                     m.title, m.genre, m.director, m.movieLength, m.releaseDate);
            }

            utfil.Close();
        }


        // Skriver ut filmerna
        public static void PrintMovies(Movie[] amountOfMovies)
        {
            Console.WriteLine("\n");
            Console.WriteLine("title   genre   director   Length   Release date");
            Console.WriteLine("-------------------------------------------------");
            for (int i = 0; i < amountOfMovies.Length; i++)
            {
                PrintMovie(amountOfMovies[i]);
            }
            Console.WriteLine("\n");
        }

        // Skriver ut film i rätt format
        public static void PrintMovie(Movie m)
        {
            Console.WriteLine(m.title + "\t" + m.genre + "\t" + m.director + "\t   " + m.movieLength + "\t    " + m.releaseDate);
        }
    }
}