using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRide
{
    public class Car
    {
        public string Model { get; set; }
        public double fuel { get; set; }
        public double fuelRate { get; set;}
        public int distance { get; set; }
        public Car(string model, double fuel, double fuelRate, int distance) 
        {
            this.Model = model;
            this.fuel = fuel;
            this.fuelRate = fuelRate;
            this.distance = distance;
        }
        public void Drive(int distance) 
        {
            if (distance * this.fuelRate < this.fuel)
            {
                this.fuel -= distance *this.fuelRate;
                this.distance += distance;
            }
            else 
            {
                Console.WriteLine("Insufficient fuel for this drive");
            }
        }
        public void EndPrint(string Model) 
        {
            Console.WriteLine($"{Model} {this.fuel} {this.distance}");
        }
    }
}
