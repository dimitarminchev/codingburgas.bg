namespace LibraryComparable
{
    public partial class Program
    {
        public class Book : IComparable<Book> 
        {
            public string Title { get; set; }
            public int Year { get; set; }

            List<string> Authors { get; set; }

            public Book(string title = " ", int year = 0, params string[] authors)
            {
                this.Title = title;
                this.Year = year;
                this.Authors = new List<string>(authors);
            }

            public int CompareTo(Book? book2)
            {
                int res = this.Year.CompareTo(book2?.Year);
                if (res == 0)
                {
                    res = this.Title.CompareTo(book2?.Title);
                }
                return res;
            }

            public override string ToString() 
            {
                return $"{this.Title} - {this.Year}";
            }
        }
    }
}