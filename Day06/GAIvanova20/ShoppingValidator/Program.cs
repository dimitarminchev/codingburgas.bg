using System.Data.SqlTypes;
using System.Reflection.Metadata;

namespace ShoppingValidator
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            Person[] people = new Person[100];
            Product[] products= new Product[100];
            
            int peopleIndex = 0, productsIndex = 0;
            string[] peopleInfo, productInfo, line;

            peopleInfo = System.Console.ReadLine().Split(";").ToArray();

            foreach (string infoPerPerson in peopleInfo)
            {
                string[] info = infoPerPerson.Split("=").ToArray();

                try
                {
                    people[peopleIndex] = new Person(info[0], double.Parse(info[1]));
                    peopleIndex++;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }

            productInfo = System.Console.ReadLine().Split(";").ToArray();

            foreach (string infoPerProduct in productInfo)
            {
                string[] info = infoPerProduct.Split("=").ToArray();

                try
                {
                    products[productsIndex] = new Product(info[0], double.Parse(info[1]));
                    productsIndex++;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }

            line = System.Console.ReadLine().Split(" ").ToArray();
            while (line[0] != "END")
            {
                for (int i = 0; i < peopleIndex; i++)
                {
                    for (int j = 0; j < productsIndex; j++)
                    {
                        if (people[i].Name == line[0] && products[j].ProductName == line[1])
                        {
                            people[i].addBoughtProduct(products[j].ProductName, products[j].Price);
                        }
                    }
                }

                line = System.Console.ReadLine().Split(" ").ToArray();
            }

            for (int i = 0; i < peopleIndex; i++)
            {
                people[i].listProducts();
                Console.WriteLine();
            }
        }
    }
}