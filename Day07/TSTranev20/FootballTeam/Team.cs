namespace FootballTeam;

public class Team
{
    public string Name { get; set; }
    public List<Player> Players { get; set; }
    public decimal Rating { get; set; }

    public Team(string name)
    {
        Name = name;
        Players = new();
    }
}
