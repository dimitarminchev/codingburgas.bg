using System.Collections;

namespace Library1
{
  
    public class Library : IEnumerable<Book>
    {
       
        public List<Book> Books { get; set; }

        
        public Library(params Book[] books)
        {
            this.Books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.Books);
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
