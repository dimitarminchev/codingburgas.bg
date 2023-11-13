namespace Bazar
{
    public class Product
    {
        private string? name;

        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("The price of a product can't be less that zero");
                price = value; 
            }
        }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}