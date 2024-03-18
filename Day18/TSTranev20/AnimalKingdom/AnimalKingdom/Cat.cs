namespace AnimalKingdom
{

    internal partial class Program
    {
        public class Cat : IAnimal
        {
            public string MakeNoise()
            {
                return "Meow!";
            }

            public string MakeTrick()
            {
                return "No trick for you! I'm too lazy!";
            }

            public void Perform()
            {
                Console.WriteLine(MakeNoise());
                Console.WriteLine(MakeTrick());
            }
        }
    }
}