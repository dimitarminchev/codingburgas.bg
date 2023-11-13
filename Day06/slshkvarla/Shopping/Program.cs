using System.Globalization;

namespace Shopping
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();

            // Pesho=11;Gosho=4
            var personItems = System.Console.ReadLine().Split(";").ToArray();
            foreach (var item in personItems)
            {
                var line = item.Split("=").ToArray();
                var name = line[0];
                var money = decimal.Parse(line[1]);
                try
                {
                    var person = new Person(name, money);
                    persons.Add(person);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    return;
                }
            }

            // Bread=10;Milk=2
            var productItems = System.Console.ReadLine().Split(";").ToArray();
            foreach (var item in productItems)
            {
                var line = item.Split("=").ToArray();
                var name = line[0];
                var money = decimal.Parse(line[1]);
                try
                {
                    var product = new Product(name, money);
                    products.Add(product);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    return;
                }
            }

            // Обработка на поръчки
            string[] cmd = System.Console.ReadLine().Split().ToArray();
            while (cmd[0] != "END")
            {
                Person person = persons.FirstOrDefault(x => x.Name == cmd[0]);
                Product product = products.FirstOrDefault(x => x.Name == cmd[1]);
                try
                {
                    person.AddProduct(product);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
                cmd = System.Console.ReadLine().Split().ToArray();
            }

            // Кой какво си е купил
            foreach (var person in persons)
            {
                var productNames = person.Products.Select(x => x.Name);
                if (productNames.Count() == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", productNames)}");
                }
            }
        }
    }
}