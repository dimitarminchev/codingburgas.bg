using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Planet> planets = new List<Planet>();
        string[] input = System.Console.ReadLine().Split().ToArray();
        for (int i = 0; i < input.Length; i += 3)
        {
            planets.Add(new Planet() { Name = input[i], Metal = int.Parse(input[i + 1]), Mineral = int.Parse(input[i + 2]) });
        }

        List<Mine> mines = new List<Mine>();
         input = System.Console.ReadLine().Split().ToArray();
        for (int i = 0; i < input.Length; i += 3)
        {
            mines.Add(new Mine() { Name = input[i], Level = int.Parse(input[i + 1]), Rate = int.Parse(input[i + 2]) });
        }

        List<Ship> ships = new List<Ship>();
        input = System.Console.ReadLine().Split().ToArray();
        for (int i = 0; i < input.Length; i += 3)
        {
            ships.Add(new Ship() { Name = input[i], Price = int.Parse(input[i + 1]), Resurces = int.Parse(input[i + 2]) });
        }


        string line = System.Console.ReadLine();
        while (line != "END")
        {
            string[] nextLine = line.Split().ToArray();
            if (nextLine.Count() == 2)
            {
                try
                {
                    Planet planet = planets.FirstOrDefault(x => x.Name == nextLine[0]);
                    Mine mine = mines.FirstOrDefault(x => x.Name == nextLine[1]);
                    planet.AddMine(mine);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                try
                {
                    Planet planet = planets.FirstOrDefault(x => x.Name == nextLine[0]);
                    Ship ship = ships.FirstOrDefault(x => x.Name == nextLine[1]);
                    int count = int.Parse(nextLine[2]);
                    planet.AddShip(ship, count);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }


            line = System.Console.ReadLine();
        }

        Console.WriteLine("Resourses:");
        foreach (Planet planet in planets)
        {
            Console.WriteLine($"{planet.Name} Metal {planet.Metal} Mineral {planet.Mineral}");
        }

        Console.WriteLine("Building:");
        foreach (Planet planet in planets)
        {
            var count = planet.GroupBy(p => p.Name).Select(g => new { Metric = g.Name, Count = g.Count() });
            Console.WriteLine($"{planet.Name} Metal {planet.Metal} Mineral {planet.Mineral}");
        }



    }
}
