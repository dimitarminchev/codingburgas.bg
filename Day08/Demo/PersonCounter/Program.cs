namespace PersonCounter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Случайно
            Random random = new Random();
            int next = random.Next(1000, 10000);

            // Случайно правене на инстанции
            List<Person> people = new List<Person>();
            for (int i = 0; i < next; i++)
            {
                people.Add(new Person());
            }

            // Извеждане на броя на хората
            Console.WriteLine($"Person Counter = {Person.Counter}"); // 0
        }
    }
}
