using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
//-    Contains a list of Episodes *
//-    Overrides parent’s Rating to return an aggregated rating of Episode ratings*
//-    Overrides ToString() method to return a string of the name of the show and number of episodes *
    public class Show : Title
    {
        List<Episode> EpisodeLibrary = new List<Episode>();
        int averageEpisodeRating;
        public Show(string name, int rating)
        {
            titleName = name;
            titleRating = rating;
        }

        public int addEpisodes()
        {
            for (int episodes = 0; episodes < 10; episodes++)
            {
                EpisodeLibrary.Add(new Episode(4));
            }
            return EpisodeLibrary.Count;
        }
       public int getRatings()
        {
            foreach(Episode episodes in EpisodeLibrary)
            {
                averageEpisodeRating = (episodes.episodeRating * EpisodeLibrary.Count)/EpisodeLibrary.Count;
            }
            return averageEpisodeRating;
        }
        public override string ToString()
        {
            return "show title: " + titleName + " ," + "number of episodes: " + " " + EpisodeLibrary.Count + " " + " average episode ratings : " +  averageEpisodeRating;
        }
        public void printShowInformation()
        {
            Console.WriteLine(ToString());
        }
    }
   
}
