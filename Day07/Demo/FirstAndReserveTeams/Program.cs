using System.Collections.Generic;

namespace FirstAndReserveTeams
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Data
            Team team = new Team("CodingBurgas");

            // Input
            int n = int.Parse(System.Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] line = System.Console.ReadLine().Split().ToArray();
                // line[0] = firstname, line[1] = lastname, line[2] = age, line[3] = salary
                team.AddPlayer(new Person
                {
                    firstname = line[0],
                    lastname = line[1],
                    age = int.Parse(line[2]),
                    salary = decimal.Parse(line[3])
                });
            }

            // Output
            Console.WriteLine($"First team have {team.FirstTeam.Count} players");
            Console.WriteLine($"Reserve team have {team.ReserveTeam.Count} players");            
        }
    }
}
