namespace ShoppingValidator
{
    public partial class Program
    {
        public class Product
        {
            private string productName;

            public string ProductName
            {
                get { return productName; }
                set 
                {
                    if (value.Equals(null))
                    {
                        throw new ArgumentException("Name cannot be empty");
                    }
                    productName = value;
                }
            }

            private double price;

            public double Price
            {
                get { return price; }
                set 
                {
                    if(value <= 0)
                    {
                        throw new ArgumentException("Money cannot be negative");
                    }
                    price = value; 
                }
            }

            public Product(string name, double price) 
            {
                this.ProductName = name;
                this.Price = price;
            }

        }
    }
}