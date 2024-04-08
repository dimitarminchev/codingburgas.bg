namespace Library1
{
    
    public class Book
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
            return $"{this.Title} ({this.Year}) by {string.Join(", ", this.Authors)}";
        }
    }
}
