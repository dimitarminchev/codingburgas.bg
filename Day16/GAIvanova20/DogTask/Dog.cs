namespace DogTask
{
    public partial class Program
    {
        public class Dog : Animal
        {
            public void Bark() 
            {
                Console.WriteLine("Dog is barking");
            }
        }
    }
}