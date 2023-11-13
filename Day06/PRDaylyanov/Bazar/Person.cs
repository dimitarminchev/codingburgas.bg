namespace Bazar
{
    public class Person
    {
        private string? name;

        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        private double money;

        public double Money
        {
            get { return money; }
            set 
            {
                if (value < 0)
                    throw new ArgumentException("Money can't be less than zero");

                money = value;
            }
        }

        private List<Product> shoppingBag;

        public List<Product> ShoppingBag
        {
            get { return shoppingBag; }
            set { shoppingBag = value; }
        }


        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money; 
            this.ShoppingBag = new List<Product>();
        }

        public void BuyProduct(Product product)
        {
            if(this.Money >= product.Price)
            {
                this.Money -= product.Price;
                this.ShoppingBag.Add(product);

                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }

        public void DisplayBag()
        {
            Console.Write($"{this.Name} - ");

            if(!this.shoppingBag.Any())
            {
                Console.WriteLine("nothing bought");
            }

            foreach(var item in this.shoppingBag) 
            {
                Console.Write(item.Name + " ");
            }

            Console.Write(Environment.NewLine);
        }
    }
}