namespace RawData
{

    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split().ToArray();

                cars.Add(new Car(
                    new Engine { Speed = int.Parse(line[1]), Power = int.Parse(line[2]) },
                    new Model { Name = line[0] },
                    new Load { Weight = int.Parse(line[3]), Type = line[4] },
                    new List<Tyres>
                    {
                        new Tyres {Pressure = double.Parse(line[5]), Age = int.Parse(line[6])},
                        new Tyres {Pressure = double.Parse(line[5]), Age = int.Parse(line[6])},
                        new Tyres {Pressure = double.Parse(line[5]), Age = int.Parse(line[6])},
                        new Tyres {Pressure = double.Parse(line[5]), Age = int.Parse(line[6])}
                    }
                    ));
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                var fragileCars = cars.Where(x => x.Load.Type == "fragile").Where(y => y.Tyres.Any(z => z.Pressure < 1));
                foreach (var car in fragileCars)
                {
                    Console.WriteLine(car.Model.Name);
                }
            }
            else if (command == "flamable")
            {
                var flamableCars = cars.Where(x => x.Load.Type == "flamable").Where(y => y.Engine.Power > 250);
                foreach (var car in flamableCars)
                {
                    Console.WriteLine(car.Model.Name);
                }
            }
            else Console.WriteLine("Invalid command!");
        }
    }
    }
}