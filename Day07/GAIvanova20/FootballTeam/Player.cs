namespace FootballTeam
{
    public class Player 
    {
        private string name;

        public string Name
        {
            get { return name; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty");
                }
                name = value; 
            }
        }
        public Stats Stats { get; set; }

    }
}