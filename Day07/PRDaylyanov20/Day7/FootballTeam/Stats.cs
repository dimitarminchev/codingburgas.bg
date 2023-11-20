namespace FootballTeam
{
    public class Stats
    {
        private int endurance;

        public int Endurance
        {
            get { return endurance; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Endurance should be between 0 and 100");
                }
                endurance = value;
            }
        }

        private int sprint;

        public int Sprint
        {
            get { return sprint; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Sprint should be between 0 and 100");
                }
                sprint = value;
            }
        }

        private int dribble;

        public int Dribble
        {
            get { return dribble; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Dribble should be between 0 and 100");
                }
                dribble = value;
            }
        }

        private int passing;

        public int Passing
        {
            get { return passing; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Passing should be between 0 and 100");
                }
                passing = value;
            }
        }

        private int shooting;

        public int Shooting
        {
            get { return shooting; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Shooting should be between 0 and 100");
                }
                shooting = value;
            }
        }

        public Stats(int endurance = 0, int sprint = 0, int dribble = 0, int passing = 0, int shooting = 0)
        {
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }
    }
}
