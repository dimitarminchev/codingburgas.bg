using System.Collections;

namespace GAIvanova20
{
    public partial class Program
    {
        public class Library : IEnumerable<Book> 
        {
            private List<Book> Books { get; set; }
            public Library(params Book[] books)
            {
                this.Books = new List<Book>(books);
            }

            public IEnumerator<Book> GetEnumerator()
            {
                return new LibraryIter(Books);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }
        }
    }
}