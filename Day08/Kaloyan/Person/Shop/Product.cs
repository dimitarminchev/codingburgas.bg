using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Product
    {
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string barcode;
		public string Barcode
		{
			get { return barcode; }
			set { barcode = value; }
		}

		private int price;
		public int Price
		{
			get { return price; }
			set { price = value; }
		}

		private int quantity;
		public int Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}

	}
}
