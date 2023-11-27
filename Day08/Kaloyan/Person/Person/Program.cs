namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person1 = new Person();
            Person person2 = new Person();
            Console.WriteLine($"Total people: {Person.GetCount()}");
        }
    }
}