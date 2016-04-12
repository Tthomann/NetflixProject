using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    //-    Duration field *
    //-    Overrides ToString() method to return a string of the name and duration of the movie *
    public class Movie : Title
    {
        public int duration;
        
        public Movie(string name, int rating, int Duration)
        {
            titleName = name;
            titleRating = rating;
            duration = Duration;
        }
        public override string ToString()
        {
            return "movie title: " + titleName + " , " + "movie rating: "+ titleRating + " , " + "length of movie: " + duration;
        }
    }
 
}
