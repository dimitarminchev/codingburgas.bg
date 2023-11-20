namespace GAIvanova20
{
    public class Team
    {
        private string name { get; set; }

        private List<Person> firstTeam { get; set; }

        public IReadOnlyCollection<Person> FirstTeam
        {
            get { return firstTeam.AsReadOnly(); }
        }

        private List<Person> reserveTeam { get; set; }

        public IReadOnlyCollection<Person> ReserveTeam
        {
            get { return reserveTeam.AsReadOnly(); }
        }

        public Team(string name)
        {
            this.name = name;
            firstTeam = new List<Person>();
            reserveTeam = new List<Person>();
        }

        public void AddPlayer(Person player)
        {
            if (player.age < 40)
            {
                firstTeam.Add(player);
            }
            else
            {
                reserveTeam.Add(player);
            }
        }
    }
}