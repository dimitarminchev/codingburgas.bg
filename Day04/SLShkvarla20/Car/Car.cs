using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Car
    {
        public string model { get; set; }

        public double fuel { get; set; }

        public double fuelForMile { get; set; }

        public int miles { get; set; }

        public Car(string model, double fuel, double fuelForMile, int miles)
        {
            this.model = model;
            this.fuel = fuel;
            this.fuelForMile = fuelForMile;
            this.miles = miles;
        }

        public void Drive(int miles)
        {
            if (fuel >= fuelForMile * miles)
            {
                fuel -= fuelForMile * miles;
                this.miles += miles;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public void OutputCar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(model + " " + fuel + " " + miles);
        }
    }
}
