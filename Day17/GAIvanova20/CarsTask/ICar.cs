namespace CarsTask
{
    public partial class Program
    {
        public interface ICar 
        {
            public string Model { get; set; }
            public string Color { get; set; }

            public string Start();
            public string Stop();
        }
    }
}