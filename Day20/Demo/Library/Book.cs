namespace Library
{
    /// <summary>
    /// Книга
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Заглавие
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Година
        /// </summary>
        public int Year { get; private set; }

        /// <summary>
        /// Автори
        /// </summary>
        public List<string> Authors { get; private set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="title">Заглавие</param>
        /// <param name="year">Година</param>
        /// <param name="authors">Автори</param>
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
