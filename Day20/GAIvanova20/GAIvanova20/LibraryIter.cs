using System.Collections;

namespace GAIvanova20
{
    public partial class Program
    {
        public class LibraryIter : IEnumerator<Book>
        {
            private List<Book> books;
            private int index;

            public LibraryIter(IEnumerable<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);
            }
            public void Dispose() {; ; }

            public Book Current => this.books[this.index];

            object IEnumerator.Current => this.Current;

            public bool MoveNext() => ++this.index < this.books.Count;

            public void Reset() => this.index = -1;
        }
    }
}