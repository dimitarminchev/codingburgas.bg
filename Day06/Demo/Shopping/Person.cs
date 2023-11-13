namespace Shopping
{
    /// <summary>
    /// Човек
    /// </summary>
    public class Person
    {
        private string name;

        /// <summary>
        /// Име
        /// </summary>
        public string Name
        {
            get { return name; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can not be null or empty.");
                }
                name = value; 
            }
        }

        private decimal money;

        /// <summary>
        /// Пари
        /// </summary>
        public decimal Money
        {
            get { return money; }
            set 
            { 
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative.");
                }
                money = value; 
            }
        }

        private List<Product> products;

        /// <summary>
        /// Продукти
        /// </summary>
        public List<Product> Products
        {
            get { return products; }
            private set { products = value; }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Products = new List<Product>();
        }

        /// <summary>
        /// Добавяне на продукт
        /// </summary>
        /// <param name="product">Продук за добавяне</param>
        /// <returns>true ако успешно добави продукта</returns>
        /// <exception cref="Exception">Не му стигат парите</exception>
        public void AddProduct(Product product)
        {
            if (this.Money >= product.Price)
            {
                this.Products.Add(product);
                this.Money -= product.Price;
                throw new Exception($"{this.Name} bought {product.Name}");
            }
            else
            {
                throw new Exception($"{this.Name} can't afford {product.Name}");
            }
        }
    }
}
