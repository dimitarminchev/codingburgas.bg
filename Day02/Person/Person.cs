using System.Diagnostics;

namespace Person
{
    /// <summary>
    /// Човек
    /// </summary>
    public class Person
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string? name;

        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine("My name is {0} and my age is {1}", name, age);
        }
    }
}