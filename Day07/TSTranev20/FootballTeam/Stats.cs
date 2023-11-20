namespace FootballTeam;

public class Stats
{
    public int Endurance { get; set; }
    public int Sprint { get; set; }
    public int Dribble { get; set; }
    public int Passing { get; set; }
    public int Shooting { get; set; }

    public Stats(int endurance = 0, int sprint = 0, int dribble = 0, int passing = 0, int shooting = 0)
    {
        Endurance = endurance;
        Sprint = sprint;
        Dribble = dribble;
        Passing = passing;
        Shooting = shooting;
    }
}
