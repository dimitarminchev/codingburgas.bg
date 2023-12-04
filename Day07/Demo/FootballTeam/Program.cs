using System.Reflection.Metadata;

namespace FootballTeam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Data Structure
            Team team = null;

            // Input
            string[] line = System.Console.ReadLine().Split(';').ToArray();
            while (line[0] != "END")
            {
                switch (line[0])
                {
                    case "Team":
                        team = new Team(line[1]);
                        break;

                    case "Add":
                        try
                        {
                            team.Players.Add(new Player
                            {
                                Name = line[2],
                                Stats = new Stats
                            (
                                int.Parse(line[3]),
                                int.Parse(line[4]),
                                int.Parse(line[5]),
                                int.Parse(line[6]),
                                int.Parse(line[7])
                            )
                            });
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case "Remove":
                        var player = team.Players.FirstOrDefault(x => x.Name == line[2]);
                        if (player != null)
                        {
                            team.Players.Remove(player);
                        }
                        else
                        {
                            Console.WriteLine($"Player {line[2]} is not in {line[1]} team");
                        }
                        break;

                    case "Rating":
                        Console.WriteLine($"{line[1]} - {team.Rating()}");
                        break;
                }
                line = System.Console.ReadLine().Split(';').ToArray();
            }
        }
    }
}
