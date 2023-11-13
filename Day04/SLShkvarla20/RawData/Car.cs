namespace RawData
{
    /// <summary>
    /// Кола
    /// </summary>
    public class Car
    {
        public Model model { get; set; }

        public Engine engine { get; set; }

        public Load load { get; set; }

        public List<Tyre> tyres { get; set; }

        public Car(Model model, Engine engine, Load load, List<Tyre> tyres)
        {
            this.model = model;
            this.engine = engine;
            this.load = load;
            this.tyres = tyres;
        }
    }
}