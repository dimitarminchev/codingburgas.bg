namespace LibraryComparable
{
    public partial class Program
    {
        public class BookComparator : IComparer<Book>
        {
            public int Compare(Book? book1, Book? book2)
            {
                int res = book1.Title.CompareTo(book2.Title);
                if (res == 0)
                {
                    res = book2.Year.CompareTo(book1.Year);
                }
                return res;
            }
        }
    }
}