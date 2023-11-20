using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    throw new ArgumentNullException("A name should not be empty");
                }
                name = value;
            }
        }

        public Stats Stats { get; set; }

        public Player(string Name, int Endurance, int Sprint, int Dribble, int Passes, int Shots) 
        {
            this.Name = Name;
            this.Stats.Endurance = Endurance;
            this.Stats.Sprint = Sprint;
            this.Stats.Dribble = Dribble;
            this.Stats.Passes = Passes;
            this.Stats.Shots = Shots;
        }
    }
}
