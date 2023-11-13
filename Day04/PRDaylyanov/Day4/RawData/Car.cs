namespace RawData
{
    public class Car
    {
        public Engine Engine { get; set; }
        public Model Model { get; set; }
        public Load Load { get; set; }
        public List<Tyres> Tyres { get; set; }

        public Car(Engine engine, Model model, Load load, List<Tyres> tyres)
        {
            this.Engine = engine;
            this.Model = model;
            this.Load = load;
            this.Tyres = tyres;
        }
    }
}