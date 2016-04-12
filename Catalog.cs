using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class Catalog
    {
     
        public Genre comedy = new Genre("Comedy");
        public Genre romance = new Genre("Romance");
        public Genre action = new Genre("Action");
        Movie StepBrothers;
        Movie TheNoteBook;
        Movie Taken;
        Show RickAndMorty;
        Show SayILoveYou;
        Show SamuraiChamploo;
       
        public Catalog()
        {
            
        }

        public void addMovie()
        {
            comedy.contentList.Add(StepBrothers = new Movie("Step Brothers", 10, 90));
            romance.contentList.Add(TheNoteBook =new Movie("The Notebook", 3, 132));
            action.contentList.Add(Taken =new Movie("Taken", 8, 160));
            

        }
        public void addShow()
        {
            comedy.contentList.Add(RickAndMorty = new Show("Rick and Morty", 7));
            romance.contentList.Add(SayILoveYou =new Show("Say I Love You", 1));
            action.contentList.Add(SamuraiChamploo = new Show("Samurai Champloo", 9));
        }
        public void MovieDisplay()
        {
            Console.WriteLine(StepBrothers.ToString());
            Console.WriteLine(TheNoteBook.ToString());
            Console.WriteLine(Taken.ToString());
        }
        public void ShowDisplay()
        {
            Console.WriteLine(RickAndMorty.ToString());
            Console.WriteLine(SayILoveYou.ToString());
            Console.WriteLine(SamuraiChamploo.ToString());
        }

    }
}
