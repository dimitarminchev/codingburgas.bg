namespace Library2
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Book book1 = new Book("The Hitchhiker's Guide to the Galaxy", 1979, "Douglas Adams");
            Book book2 = new Book("Foundation", 1951, "Isaac Asimov");

            int compare = book1.CompareTo(book2);
            switch (compare)
            {
                case 0:
                    Console.WriteLine("Equal Books!");
                    break;
                case 1:
                    Console.WriteLine("Newer Book: {0}", book1.ToString());
                    break;
                case -1:
                    Console.WriteLine("Newer Book: {0}", book2.ToString());
                    break;
            }


            var comparator = new BookComparator();
            int compare2 = comparator.Compare(book1, book1);
            switch (compare2)
            {
                case 0:
                    Console.WriteLine("Equal Books!");
                    break;
                case 1:
                    Console.WriteLine("Newer Book: {0}", book1.ToString());
                    break;
                case -1:
                    Console.WriteLine("Newer Book: {0}", book2.ToString());
                    break;
            }

        }
    }
}
