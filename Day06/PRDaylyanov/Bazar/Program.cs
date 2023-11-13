using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Bazar
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            var items = Console.ReadLine().Split(';').ToArray();

            foreach(var item in items) 
            {
                var line = item.Split('=').ToArray();

                var name = line[0];
                var money = double.Parse(line[1]);
                try
                {
                    Person person = new Person(name, money);
                    people.Add(person);
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            items = Console.ReadLine().Split(';').ToArray();

            foreach (var item in items)
            {
                var line = item.Split('=').ToArray();

                var name = line[0];
                var price = double.Parse(line[1]);
                try
                {
                    Product product = new Product(name, price);
                    products.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            var query = Console.ReadLine().Split(" ").ToArray();

            while (query[0] != "END")
            {
                Person person = people.FirstOrDefault(x  => x.Name == query[0]);
                Product product = products.FirstOrDefault(x => x.Name == query[1]);

                person.BuyProduct(product);

                query = Console.ReadLine().Split(" ").ToArray();
            }

            foreach (var item in people)
            {
                item.DisplayBag();
            }
        }
    }
}