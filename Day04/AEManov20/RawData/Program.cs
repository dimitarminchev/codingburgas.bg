namespace RawData;
class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new();
        int n = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < n; i++)
        {
            string[] line = Console.ReadLine().Split().ToArray();

            cars.Add(new Car(
                new Model() { Name = line[0] },
                new Engine() { Speed = int.Parse(line[1]), Power = int.Parse(line[2]) },
                new Load() { Weight = int.Parse(line[3]), Type = line[4] },
                new List<Tire>()
                {
                    new() { Pressure = double.Parse(line[5]), Age = int.Parse(line[6]) },
                    new() { Pressure = double.Parse(line[7]), Age = int.Parse(line[8]) },
                    new() { Pressure = double.Parse(line[9]), Age = int.Parse(line[10]) },
                    new() { Pressure = double.Parse(line[11]), Age = int.Parse(line[12]) }
                }
            ));
        }
        
        string command = Console.ReadLine()!;

        List<Car> result;
        
        if (command == "fragile")
        {
            result = cars.Where(x => x.Load.Type == "fragile").Where(y => y.Tires.Any(z => z.Pressure < 1)).ToList();
        }
        else if (command == "flamable")
        {
            result = cars.Where(x => x.Load.Type == "flamable").Where(y => y.Engine.Power > 250).ToList();
        }
        else
        {
            result = new List<Car>();
        }

        foreach (var car in result)
        {
            Console.WriteLine(car.Model.Name);
        }
    }
}
