using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    //-    Contains a list of Titles *
    //-    Implement custom iterator to iterate over those Titles *
    //-    Overload plus(+) operator to take in two Genres and return the aggregated Genre.*
    //o    For example, if we want to create an aggregated genre Romantic Comedy, all the film titles in that specific genre would include film titles from Romance*
    //-    Overload plus(+) operator to take in a Genre and a Title to return the aggregated Genre.
    //o    Take in a title, add it to the genre, return an aggregated list.
    //o    For example, title Die Hard and genre Comedy would return a list of all comedy films and Die Hard.
    //-    Create the genres: All, Romance, Action, Comedy.They need to share some titles (such as Romantic Comedies) by reference, not by duplicating the title itself
    public class Genre
    {

        public string genreType;
        public List<Title> contentList = new List<Title>();

        public Genre(string GenreType)
        {
            genreType = GenreType;
            
        }
        public IEnumerator<Title> GetEnumerator()
        {

            foreach (Title titles in contentList)
            {
                yield return titles;
                yield break;
            }

        }

        public static Genre operator +(Genre catagoryA,Genre catagoryB)
        {   
            Genre combinedGenre = new Genre(catagoryA.genreType + catagoryB.genreType);
            combinedGenre.contentList.AddRange(catagoryA.contentList);
            combinedGenre.contentList.AddRange(catagoryB.contentList);
           
           
            return combinedGenre;
        }
    
    }
}

