namespace Teams
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team("codingburgas");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split().ToArray();
                team.AddPlayer(new Person()
                {
                    FirstName = line[0],
                    LastName = line[1],
                    Age = int.Parse(line[2]),
                    Salary = double.Parse(line[3])
                });
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players");
        }
    }
}