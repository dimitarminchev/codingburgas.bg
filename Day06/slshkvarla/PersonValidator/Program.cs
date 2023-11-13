namespace PersonValidator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person ivan = new Person(age: 21);
            Console.WriteLine(ivan);

            try 
            {
                Person peter = new Person("Peter", "Petrov", -100, 462);
                Console.WriteLine(peter);
            }
            catch (Exception error) 
            {
                Console.WriteLine($"Error: {error.Message}");
            }
        }
    }
}