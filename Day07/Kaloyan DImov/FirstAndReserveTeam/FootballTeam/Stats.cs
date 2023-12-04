using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    throw new ArgumentOutOfRangeException("Endurance should be between 0 and 100");
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
                    throw new ArgumentOutOfRangeException("Sprint should be between 0 and 100");
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
                    throw new ArgumentOutOfRangeException("Dribble should be between 0 and 100");
                }
                dribble = value;
            }
        }

        private int passes;
        public int Passes
        {
            get { return passes; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Passes should be between 0 and 100");
                }
                passes = value;
            }
        }

        private int shots;

        public int Shots
        {
            get { return shots; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Shots should be between 0 and 100");
                }
                shots = value;
            }
        }

    }
}
