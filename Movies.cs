using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio
{
    public class Movie
    {
        public string title;
        public string genre;
        public string director;
        public double movieLength;
        public string releaseDate;
        public bool onLoan;
        public bool available;

        public override string ToString()
        {
            return title + " " + genre + ", " + director + ", " + movieLength + ", " + releaseDate;
        }
    }

}