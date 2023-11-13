namespace RawData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(System.Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] line = System.Console.ReadLine().Split(' ').ToArray();
                cars.Add(new Car
                        (
                            new Model { Name = line[0] },
                            new Engine { Speed = int.Parse(line[1]), Power = int.Parse(line[2]) },
                            new Load { Weight = int.Parse(line[3]), Type = line[4] },
                            new List<Tyres>
                            {
                                new Tyres { Pressure = double.Parse(line[5]), Age = int.Parse(line[6])},
                                new Tyres { Pressure = double.Parse(line[7]), Age = int.Parse(line[8]) },
                                new Tyres { Pressure = double.Parse(line[9]), Age = int.Parse(line[10]) },
                                new Tyres { Pressure = double.Parse(line[11]), Age = int.Parse(line[12]) }
                            }
                        )
                    );
            }
            string command = System.Console.ReadLine();
            if (command == "fragile")
            {
                var fragileCars = cars.Where(x => x.load.Type == "fragile").Where(y => y.tyres.Any(z => z.Pressure < 1));
                foreach (var car in fragileCars)
                {
                    Console.WriteLine(car.model.Name);
                }
            }
            else if (command == "flamable")
            {
                var flamableCars = cars.Where(x => x.load.Type == "flamable").Where(y => y.engine.Power > 250);
                foreach (var car in flamableCars)
                {
                    Console.WriteLine(car.model.Name);
                }
            }
            else 
            {
                Console.WriteLine("Invcalid command!");
            }
        }
    }
}