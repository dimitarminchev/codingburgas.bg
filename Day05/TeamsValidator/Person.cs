namespace TeamsValidator
{
    /// <summary>
    /// Човек
    /// </summary>
    public class Person
    {
        private string firstName;

        /// <summary>
        /// Име
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set 
            {
                // Имената не трябва да са по малко от 3 символа
                if (value.Length < 3)
                {
                    throw new ArgumentException("Names must be 3 or more symbols.");
                }
                firstName = value; 
            }
        }

        private string lastName;

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set
            {
                // Имената не трябва да са по малко от 3 символа
                if (value.Length < 3)
                {
                    throw new ArgumentException("Names must be 3 or more symbols.");
                }
                lastName = value;
            }
        }

        private int age;

        /// <summary>
        /// Възраст
        /// </summary>
        public int Age
        {
            get { return age; }
            set 
            {
                // Възрастта трябва да е по-голяма от нула
                if (value <= 0)
                {
                    throw new ArgumentException("Age must be greater than zero.");
                }
                age = value; 
            }
        }

        private decimal salary;

        /// <summary>
        /// Заплата
        /// </summary>
        public decimal Salary
        {
            get { return salary; }
            set 
            {
                // Заплатата трябва да е по-голяма по 460 единици
                if (value <= 460)
                {
                    throw new ArgumentException("Salary must be grater than 460");
                }
                salary = value; 
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="firstname">Име</param>
        /// <param name="lastname">Фамилия</param>
        /// <param name="age">Възраст</param>
        /// <param name="salary">Заплата</param>
        public Person(string firstname = "John", string lastname = "Doe", int age = 1, decimal salary = 461)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Salary = salary;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"firstname: {firstName}, lastname: {lastName}, age: {age}, salary: {salary}";
        }
    }
}