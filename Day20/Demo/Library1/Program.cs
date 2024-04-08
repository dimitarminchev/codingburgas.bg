namespace Library1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Колеция за книги
            List<Book> books = new List<Book>();

            // Добавяме книги към колецията
            books.Add(new Book("The Hitchhiker's Guide to the Galaxy", 1979, "Douglas Adams"));
            books.Add(new Book("Foundation", 1951, "Isaac Asimov"));
            books.Add(new Book("The Lord of the Rings", 1954, "J.R.R. Tolkien"));

            // Обхождаме и отпечатваме книгите от колецията
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
