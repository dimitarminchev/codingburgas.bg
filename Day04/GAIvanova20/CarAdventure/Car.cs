namespace CarAdventure
{
    public class Car 
    {
        public string Model { get; set; }
        public double Fuel { get; set; }
        public double FuelConsumption { get; set; }
        public double Distance { get; set; }

        public Car(string model, double fuel, double fuelConsumption) 
        {
            this.Model = model;
            this.Fuel = fuel;
            this.FuelConsumption = fuelConsumption;
            this.Distance = 0;
        }

        public void drive(double distance)
        {
            double fuelNeeded = FuelConsumption * distance;
            if (Fuel > fuelNeeded)
            {
                Fuel -= fuelNeeded;
                Distance += distance;
            }
            else 
            {
                Console.WriteLine("Insufficient fuel for the driver");
            }
        }

        public void printCarInfo()
        {
            Console.WriteLine($"{Model} {Fuel} {Distance}");
        }
    }
}