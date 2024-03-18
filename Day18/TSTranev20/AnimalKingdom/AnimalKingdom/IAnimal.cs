namespace AnimalKingdom
{

    internal partial class Program
    {
        public interface IAnimal: IMakeNoise, IMakeTrick
        {
            public void Perform();
        }
    }
}