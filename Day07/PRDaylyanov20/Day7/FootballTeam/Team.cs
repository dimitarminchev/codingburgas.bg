namespace FootballTeam
{
    public class Team
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }
        public List<Player> Players { get; set; }
        public Team(string name)
        {
            this.name = name;
            this.Players = new List<Player>();
        }
        public int Rating()
        {
            if (Players.Count == 0)
            {
                return 0;
            }

            double sum = Players.Sum(x => (x.Stats.Endurance + x.Stats.Sprint + x.Stats.Dribble + x.Stats.Passing + x.Stats.Shooting) / 5.0);

            double avr = sum / Players.Count();

            return (int)Math.Round(avr);
        }

    }
}
