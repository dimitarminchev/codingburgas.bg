using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckSystem
{
    public class Truck
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private double loadCapacity;

		public double LoadCapacity
		{
			get { return loadCapacity; }
			set { loadCapacity = value; }
		}

		public List<Freight> freightQuantity = new List<Freight>();


		public void Load(Freight freight)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			if (freight.Weight <= this.loadCapacity)
			{
				this.loadCapacity -= freight.Weight;
				this.freightQuantity.Add(freight);
                Console.WriteLine($"{this.name} loaded {freight.Name}");
            }
			else
			{
                Console.WriteLine($"{this.name} can not load {freight.Name}");
            }
		}

		public void ShowLoadedFreights()
		{
            Console.ForegroundColor = ConsoleColor.Green;
            if (freightQuantity.Count() > 0)
			{
				Console.Write($"{this.name} - {freightQuantity[0].Name}");
				for (int i = 1; i < freightQuantity.Count(); i++)
				{
					Console.Write($", {freightQuantity[i].Name}");
                }
				Console.WriteLine();
			}
			else
			{
                Console.WriteLine($"{this.name} - Nothing loaded");
            }
		}
	}
}
