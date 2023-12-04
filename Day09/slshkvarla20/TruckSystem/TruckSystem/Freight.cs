using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckSystem
{
    public class Freight
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private double weight;

		public double Weight
		{
			get { return weight; }
			set { weight = value; }
		}
	}
}
