namespace LibraryComparable
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            Book book1 = new Book("Animal Farm", 2003, "George Orwell");
            Book book2 = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");

            Console.WriteLine("Comparable:");

            int comparableResult = book1.CompareTo(book2);
            switch (comparableResult)
            {
                case 0:
                    Console.WriteLine("Equal");
                    break;
                case 1:
                    Console.WriteLine(book2.ToString() + " is newer");
                    break;
                case -1:
                    Console.WriteLine(book1.ToString() + " is newer");
                    break;
            }

            Console.WriteLine("Comparator:");

            BookComparator comparator = new BookComparator();
            int comparatorResult = comparator.Compare(book1, book1);
            switch (comparatorResult)
            {
                case 0:
                    Console.WriteLine("Equal");
                    break;
                case 1:
                    Console.WriteLine(book1.ToString() + " is newer");
                    break;
                case -1:
                    Console.WriteLine(book2.ToString() + " is newer");
                    break;
            }
        }
    }
}