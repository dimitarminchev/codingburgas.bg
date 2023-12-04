namespace PersonCounter
{
    /// <summary>
    /// Човек
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Статично поле
        /// </summary>
        private static int counter = 0;

        /// <summary>
        /// Статично свойство
        /// </summary>
        public static int Counter
        {
            get { return counter; }
        }

        private string name;

        /// <summary>
        /// Име на човека
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;

        /// <summary>
        /// Възраст на човека
        /// </summary>
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        /// <summary>
        /// Конструктор 
        /// </summary>
        /// <param name="name">Име</param>
        /// <param name="age">Възраст</param>
        public Person(string name = "Noname", int age = 0)
        {
            this.Name = name;
            this.Age = age;

            // Увеличаваме брояча при създаване на инстанция на класа
            counter++;
        }
    }
}
