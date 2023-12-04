namespace FootballTeam
{
    /// <summary>
    /// Играч
    /// </summary>
    public class Player
    {
        private string name;

        /// <summary>
        /// Име
        /// </summary>
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

        /// <summary>
        /// Статистики
        /// </summary>
        public Stats Stats { get; set; }
    }
}
