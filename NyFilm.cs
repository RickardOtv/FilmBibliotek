using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio
{
    partial class Program
    {

        public static Movie CreateMovie(string title, string genre, string director, double length, string releaseDate)
        {
            Movie m = new Movie();
            m.title = title;
            m.genre = genre;
            m.director = director;
            m.movieLength = length;
            m.releaseDate = releaseDate;
            return m;
        }

    }
}