﻿namespace Library2
{
   
    public class Book : IComparable<Book> 
    {
       
        public string Title { get; private set; }

       
        public int Year { get; private set; }

        public List<string> Authors { get; private set; }

       
        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = new List<string>(authors);
        }

        override public string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }

       
        public int CompareTo(Book? other)
        {
            int result = this.Year.CompareTo(other?.Year);
            if (result == 0)
            {
                result = this.Title.CompareTo(other?.Title);
            }
            return result;

        }
    }
}
