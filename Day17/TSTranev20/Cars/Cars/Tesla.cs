namespace Cars
{

    public class Tesla : IElecricCar, ICar
    {
     
        public string Model { get; set; }
        public string Color { get; set; }

        public int Batteries { get; set; }


        public Tesla(string model, string color, int batteries)
        {
            Model = model;
            Color = color;
            Batteries = batteries;
        }


        public string Start()
        {
            return string.Format("Engine start");
        }

      
        public string Stop()
        {
            return string.Format("Breaaak!");
        }

        public override string ToString()
        {
            return string.Format("{0} Tesla {1} with {2} Batteries\n{3}\n{4} ", Color, Model, Batteries, Start(), Stop());
        }
    }
}
