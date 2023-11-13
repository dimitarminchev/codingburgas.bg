namespace ShoppingValidator
{
    public partial class Program
    {
        public class Person 
        {
            private string name;

            public string Name
            {
                get { return name; }
                set 
                {
                    if (value.Equals(null))
                    {
                        throw new ArgumentException("Name cannot be empty");
                    }
                    name = value; 
                }
            }

            private double money;

            public double Money
            {
                get { return money; }
                set 
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Money cannot be negative");
                    }
                    money = value; 
                }
            }

            private List<string> boughtProducts;

            public List<string> BoughtProducts
            {
                get { return boughtProducts; }
                set { boughtProducts = value; }
            }

            public Person(string name, double money) 
            {
                this.Name = name;
                this.Money = money;
                this.BoughtProducts = new List<string>();
            }

            public void addBoughtProduct(string productName, double price)
            {
                if (Money < price)
                {
                    Console.WriteLine($"{Name} can't afford {productName}");
                }
                else
                {
                    Money -= price;
                    boughtProducts.Add(productName);

                    Console.WriteLine($"{Name} bought {productName}");
                }
            }

            public void listProducts()
            {
                if (BoughtProducts.Count == 0)
                {
                    Console.WriteLine($"{Name} - Nothing bought");
                }
                else
                {
                    Console.Write($"{Name} - ");
                    for (int i = 0; i < BoughtProducts.Count - 1; i++)
                    {
                        Console.Write($"{BoughtProducts[i]}, ");
                    }
                    Console.Write(BoughtProducts[BoughtProducts.Count - 1]);
                }
            }
        }
    }
}