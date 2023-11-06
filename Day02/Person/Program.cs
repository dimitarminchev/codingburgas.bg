namespace Person
{
    /// <summary>
    /// Glawna programa
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Person pesho = new Person();

            pesho.Age = 15;
            pesho.Name = "Гошо";

            pesho.IntroduceYourself();
        }
    }
}