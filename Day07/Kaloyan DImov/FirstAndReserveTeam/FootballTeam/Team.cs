using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    throw new ArgumentNullException("A name should not be empty");
                }
                name = value;
            }
        }
        public List<Player> Players { get; set; }
        public decimal Rating { get; set; }

        public Team(string Name) 
        {
            this.name = Name;
            this.Players = new List<Player>();
        }
    }
}
