namespace RawData
{
    public class Car 
    {
        public Engine engine { get; set; } 
        public Load load { get; set; }
        public List<Tyre> tyres { get; set; }
        public Model model { get; set; }

        public Car(Engine engine, Load load, Model model, List<Tyre> tyres) 
        {
            this.engine = engine;
            this.load = load;
            this.model = model;
            this.tyres = tyres;
        }

        public Car(Model model, Engine engine, Load load, List<Tyre> tyres)
        {
            this.model = model;
            this.engine = engine;
            this.load = load;
            this.tyres = tyres;
        }
    }
}