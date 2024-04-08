using System.Collections;

namespace Library
{
    /// <summary>
    /// Итератор за библиотеката
    /// </summary>
    public class LibraryIterator : IEnumerator<Book>
    {
        private List<Book> books;

        private int currentIndex;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="books">Списък с книги</param>
        public LibraryIterator(IEnumerable<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books); 
        }

        public void Dispose() { ;; }

        public Book Current => this.books[this.currentIndex];

        object IEnumerator.Current => this.Current;

        public bool MoveNext() => ++this.currentIndex < this.books.Count;

        public void Reset() => this.currentIndex = -1;
    }
}
