namespace AnimalKingdom
{

    internal partial class Program
    {
        public class Dog : IAnimal
        {
            public string MakeNoise()
            {
                return "Woof!";
            }

            public string MakeTrick()
            {
                return "Hold my paw, human!";
            }

            public void Perform()
            {
                Console.WriteLine(MakeNoise());
                Console.WriteLine(MakeTrick());
            }
        }
    }
}