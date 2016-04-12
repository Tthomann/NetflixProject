using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    //-    Name field *
    //-    Rating field *
    //-    Overload plus(+) operator to take in two Titles and return an aggregated Genre
    //-    Offer two overloaded constructors: one that takes in all the fields and sets them, another that takes in no fields and sets the internal fields to null. ???
    public class Title
    {
        public string titleName;
        public int titleRating;

        public Title(string TitleName, int TitleRating)
        {
            TitleName = titleName;
            TitleRating = titleRating;


        }
        public Title()
        {
            string TitleName = null;
            int? TitleRating = null;
        }
        //public static Genre operator +(Title titleA, Title titleB)
        //{
        //    Genre combinedTitle = new Genre(titleA.titleName + titleB.titleName);
        //    combinedTitle.contentList.AddRange(titleA.titleName);
        //    combinedTitle.contentList.AddRange(titleB.titleName);
        //    return combinedTitle;
        //}        
        
}
}
