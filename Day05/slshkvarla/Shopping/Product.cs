namespace Shopping
{
    /// <summary>
    /// Продукт
    /// </summary>
    public class Product
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

        private decimal price;

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price
        {
            get { return price; }
            set 
            { 
                if (value <= 0)
                {
                    throw new ArgumentException("Price can not be negative.");
                }
                price = value; 
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Име</param>
        /// <param name="price">Цена</param>
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
