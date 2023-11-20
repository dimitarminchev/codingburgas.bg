namespace GAIvanova20
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Team team = new Team("codingburgas");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split().ToArray();

                team.AddPlayer(new Person
                {
                    firstname = line[0],
                    lastname = line[1],
                    age = int.Parse(line[2]),
                    salary = double.Parse(line[3])
                });
            }

            Console.WriteLine($"First team have {team.FirstTeam.Count} players");
            Console.WriteLine($"Reserved team have {team.ReserveTeam.Count} players");
        }
    }
}