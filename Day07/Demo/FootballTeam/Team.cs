using System.ComponentModel;

namespace FootballTeam
{
    /// <summary>
    /// Екип
    /// </summary>
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

        public decimal Rating { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Име на екип</param>
        public Team(string name)
        {
            this.name = name;
            this.Players = new List<Player>();
        }
    }
}
