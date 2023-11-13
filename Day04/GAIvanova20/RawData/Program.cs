namespace RawData
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            // Data Structure
            List<Car> cars = new List<Car>();

            // Input
            int n = int.Parse(System.Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] line = System.Console.ReadLine().Split(' ').ToArray();

                cars.Add(new Car
                (
                    new Model { name = line[0] },
                    new Engine { speed = int.Parse(line[1]), power = int.Parse(line[2]) },
                    new Load { weight = int.Parse(line[3]), type = line[4] },
                    new List<Tyre>
                    {
                    new Tyre { pressure = double.Parse(line[5]), age = int.Parse(line[6]) },
                    new Tyre { pressure = double.Parse(line[7]), age = int.Parse(line[8]) },
                    new Tyre { pressure = double.Parse(line[9]), age = int.Parse(line[10]) },
                    new Tyre { pressure = double.Parse(line[11]), age = int.Parse(line[12]) }
                    }
                ));

            }
            // Command: fragile or flamable
            string command = System.Console.ReadLine();
            if (command == "fragile")
            {
                // fragile: товара fragile с гуми с налягане < 1;
                var fragileCars = cars.Where(x => x.load.type == "fragile").Where(y => y.tyres.Any(z => z.pressure < 1));
                foreach (var car in fragileCars)
                {
                    System.Console.WriteLine(car.model.name);
                }
            }
            else if (command == "flamable")
            {
                // flamable: товара flamable и мощност на двигателя > 250
                var flamableCars = cars.Where(x => x.load.type == "flamable").Where(y => y.engine.power > 250);
                foreach (var car in flamableCars)
                {
                    System.Console.WriteLine(car.model.name);
                }
            }
            else System.Console.WriteLine("Invalid command!");
        }
    }
}
