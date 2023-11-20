namespace CarTravel
{
    public class Car
    {
        public string Model { get; set; }

        public double Fuel { get; set; }

        public double FuelPerKm { get; set; }

        public double DistanceTravelled { get; set; }

        public Car(string model, double fuel, double fuelPerKm)
        {
            Model = model;
            Fuel = fuel;
            FuelPerKm = fuelPerKm;
        }

        public void Travel(double distance)
        {
            double fuelConsumed = distance * this.FuelPerKm;

            if(fuelConsumed > this.Fuel)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.DistanceTravelled += distance;
                this.Fuel -= fuelConsumed;
                Console.WriteLine($"{this.Model}{this.Fuel}{this.DistanceTravelled}");
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> Cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] carInput = Console.ReadLine().Split().ToArray();

                Cars.Add(
                    new Car{ 
                        Model = carInput[0],
                        Fuel = double.Parse(carInput[1]),
                        FuelPerKm = double.Parse(carInput[2])
                    }
                ));
            }
        }
    }
}