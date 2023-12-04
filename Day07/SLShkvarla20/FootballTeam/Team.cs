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

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Име на екип</param>
        public Team(string name)
        {
            this.name = name;
            this.Players = new List<Player>();
        }

        /// <summary>
        /// Рейтинг
        /// </summary>
        public int Rating()
        {
            if (Players.Count == 0)
            {
                return 0;
            }

            // Сума на всички статистики за всички играчи
            double sum = Players.Sum(x => (x.Stats.Endurance + x.Stats.Sprint + x.Stats.Dribble + x.Stats.Passing + x.Stats.Shooting) / 5.0);
           
            // Средно аритетично получаваме, като раздели сумата на броя на играчите
            double avr = sum / Players.Count();

            // Връщаме цяло число
            return (int)Math.Round(avr);
        }

    }
}
