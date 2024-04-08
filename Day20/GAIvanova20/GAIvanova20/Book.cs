namespace GAIvanova20
{
    public partial class Program
    {
        public class Book 
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

        }
    }
}