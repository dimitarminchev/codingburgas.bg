namespace TeamsValidator
{
    /// <summary>
    /// Отбори
    /// </summary>
    public class Teams
    {
        private string name;

        /// <summary>
        /// Име на отбор
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private List<Person> firstTeam;

        /// <summary>
        /// Първи отбор
        /// </summary>
        public List<Person> FirstTeam
        {
            get { return firstTeam; }
            private set { firstTeam = value; }
        }

        private List<Person> reserveTeam;

        /// <summary>
        /// Резервен отбор
        /// </summary>
        public List<Person> ReserveTeam
        {
            get { return reserveTeam; }
            private set { reserveTeam = value; }
        }

        /// <summary>
        /// Добавяне на играч към отбор
        /// </summary>
        /// <param name="person">Човек</param>
        public void AddPerson(Person person)
        {
            if (person.Age < 40)
            {
                firstTeam.Add(person);
            }
            else
            {
                reserveTeam.Add(person);
            }
        }

        /// <summary>
        /// Конструктора
        /// </summary>
        public Teams(string name)
        {
            this.Name = name;
            this.FirstTeam = new List<Person>();
            this.ReserveTeam = new List<Person>();
        }

    }
}
