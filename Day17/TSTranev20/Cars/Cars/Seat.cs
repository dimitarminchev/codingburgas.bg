namespace Cars
{

    public class Seat : ICar
    {

        public string Model { get; set; }

        public string Color { get; set; }


        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
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
            return string.Format("{0} Seat {1}\n{2}\n{3}", Color, Model, Start(), Stop());
        }
    }
}
