namespace Animals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Demonstrates moethod overriding
            Dog dog = new Dog("Stan", "cheese");
            Console.WriteLine(dog.ExplainMyself());

            Cat cat = new Cat("Tamara", "mouses");
            Console.WriteLine(cat.ExplainMyself());
        }
    }
}
