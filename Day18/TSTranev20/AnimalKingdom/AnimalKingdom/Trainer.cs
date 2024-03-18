namespace AnimalKingdom
{

    internal partial class Program
    {
        public class Trainer
        {
            public IAnimal entity { get; set; }

            public Trainer(IAnimal entity)
            {
                this.entity = entity;
            }

            public void Make()
            {
                entity.Perform();
            }
        }
    }
}