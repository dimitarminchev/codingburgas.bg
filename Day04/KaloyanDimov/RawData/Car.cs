namespace RawData
{
    public class Car 
    {
        public Model model { get; set; }
        public Engine engine { get; set; }
        public Load load { get; set; }
        public List<Tyres> tyres { get; set; }
        public Car(Model model, Engine engine, Load load, List<Tyres> tires) 
        {
            this.model = model;
            this.engine = engine;
            this.load = load;
            this.tyres = tires;
        }
    }
}