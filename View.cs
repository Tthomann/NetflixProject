using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    //-    Prints out the various Genres and their Titles
    public class View 
    {
        Catalog catalog = new Catalog();
        public int input;
        public string movieInput;
        public bool done;
        public View() {
            catalog.addMovie();
            catalog.addShow();
            
        }
        public void netflixMenu()
        {
            while (!done) {
            Console.WriteLine("press 1 to view romantic entertainment and comedy entertainment list");
            Console.WriteLine("press 2 to view comedic entertainment and action entertainment list");
            Console.WriteLine("press 3 to view romantic entertainment and action entertainment list");
            Console.WriteLine("press 4 to display information on all movies");
            Console.WriteLine("press 5 to display information on all shows");
            input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {

                    case 1:
                        Console.WriteLine(" ");
                        Genre ComedyRomance = catalog.comedy + catalog.romance;
                        Console.WriteLine("-------------------------");
                        Console.WriteLine(ComedyRomance.genreType);
                        Console.WriteLine("-------------------------");
                        foreach (Title name in ComedyRomance.contentList)
                        {
                            Console.WriteLine(name.titleName);
                        }
                        Console.WriteLine(" ");
                        break;
                    case 2:
                        Console.WriteLine(" ");
                        Genre ComedyAction = catalog.comedy + catalog.action;
                        Console.WriteLine("-------------------------");
                        Console.WriteLine(ComedyAction.genreType);
                        Console.WriteLine("-------------------------");

                        foreach (Title name in ComedyAction.contentList)
                        {
                            Console.WriteLine(name.titleName.ToString());
                        }
                        Console.WriteLine(" ");
                        break;
                    case 3:
                        Console.WriteLine(" ");
                        Genre RomanticAction = catalog.romance + catalog.action;
                        Console.WriteLine("-------------------------");
                        Console.WriteLine(RomanticAction.genreType);
                        Console.WriteLine("-------------------------");

                        foreach (Title name in RomanticAction.contentList)
                        {
                            Console.WriteLine(name.titleName);
                        }
                        Console.WriteLine(" ");
                        break;
                    case 4:
                        Console.WriteLine(" ");
                        catalog.MovieDisplay();
                        Console.WriteLine(" ");
                        break;
                    case 5:
                        Console.WriteLine(" ");
                        catalog.ShowDisplay();
                        Console.WriteLine(" ");
                        break;
                    case 6:
                        
                        done = true;
                        break;
                }
            }
        }
       
    }
}
