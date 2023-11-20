using System.Numerics;

namespace FootballTeam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(';').ToArray();
            List<Team> teams = new List<Team>();
            int average = 0;
            while (line[0] != "End") 
            {
                bool Team = false;
                bool Player = false;
                bool Stats = false;
                if (line[0] == "Team")
                {
                    Team team = new Team(line[1]);
                    teams.Add(team);
                }
                else if (line[0] == "Add")
                {
                    foreach (Team team1 in teams)
                    {
                        if (team1.Name == line[1])
                        {
                            Player player = new Player(line[2], int.Parse(line[3]), int.Parse(line[4]), int.Parse(line[5]), int.Parse(line[6]), int.Parse(line[7]));
                            team1.Players.Add(player);
                            Team = true;
                        }
                    }
                    if (Team == false)
                    {
                        Console.WriteLine($"Team {line[1]} does not exist.");
                    }
                }
                else if (line[0] == "Remove")
                {
                    foreach (Team team1 in teams)
                    {
                        if (team1.Name == line[1])
                        {
                            foreach (Player player1 in team1.Players)
                            {
                                if (player1.Name == line[2])
                                {
                                    team1.Players.Remove(player1);
                                    Player = true;
                                }
                            }

                        }
                    }
                    if (Player == false)
                    {
                        Console.WriteLine($"Player {line[2]} is not in {line[1]} team.");
                    }
                }
                else if (line[0] == "Rating") 
                {
                    foreach (Team team1 in teams)
                    {
                        if (team1.Name == line[1]) 
                        {
                            foreach (Player player1 in team1.Players) 
                            {
                                average += (player1.Stats.Endurance + player1.Stats.Shots + player1.Stats.Sprint + player1.Stats.Dribble + player1.Stats.Passes)/5;
                            }
                            Stats = true;
                        }
                    }
                    Console.WriteLine($"{line[1]} - {average}");
                    if (Stats == false)
                    {
                        Console.WriteLine($"Team {line[1]} does not exist.");
                    }
                }
                line = Console.ReadLine().Split(';').ToArray();
            }
        }
    }
}