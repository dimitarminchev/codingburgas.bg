using System.Collections;

namespace Library1
{
    /// <summary>
    /// Библиотека
    /// </summary>
    public class Library : IEnumerable<Book>
    {
        /// <summary>
        /// Книги
        /// </summary>
        public List<Book> Books { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="books">Книги</param>
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
