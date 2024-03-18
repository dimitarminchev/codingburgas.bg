namespace AnimalKingdom
{

    internal partial class Program
    {

        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            Trainer trainer = new Trainer(cat);
            trainer.Make();
            trainer = new Trainer(dog);
            trainer.Make();
        }
    }
}