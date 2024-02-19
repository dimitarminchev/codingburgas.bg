namespace AnimalsTask
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Console.WriteLine();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}