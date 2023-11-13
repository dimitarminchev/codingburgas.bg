namespace Roadtrips;
class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new();

        int n = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < n; i++)
        {
            string[] line = Console.ReadLine().Split().ToArray();

            cars.Add(new Car()
            {
                Model = line[0],
                FuelLeft = decimal.Parse(line[1]),
                FuelPerKilometer = decimal.Parse(line[2])
            });
        }

        string command = Console.ReadLine()!;

        while (command != "End")
        {
            string[] parameters = command.Split();

            if (parameters[0] != "Drive") continue;
            string carName = parameters[1];
            decimal kilometersToDrive = decimal.Parse(parameters[2]);

            cars.FirstOrDefault(x => x.Model == carName).Drive(kilometersToDrive);

            command = Console.ReadLine()!;
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car.ToString());
        }
    }
}
