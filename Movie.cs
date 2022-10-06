using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesTests
{
    public class Movie
    {
        public string title;
        private string rating;

        public Movie(string aTitle,string aRating)
        {
            title = aTitle;
            Rating = aRating;
        }   
        public string Rating
        {
            get { return rating; }
            set { 
                if(value == "PG"||value == "PG-13"||value == "A")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
