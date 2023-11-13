namespace TeamsValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Списък със играчи
            List<Person> players = new List<Person>
            {
                new Person("Ivan", "Ivanov", 21, 462),
                new Person("Peter", "Petrov", 23, 823),
                new Person("Maria", "Ivanova", 46, 567),
                new Person("Svetla", "Dimitrowa", 32, 567)
            };

            // Екип
            Teams team = new Teams("The Best");
            foreach (var player in players) 
            {
                team.AddPerson(player);
            }

            // Брой на играчите
            Console.WriteLine($"Fisrt Team: {team.FirstTeam.Count}");
            Console.WriteLine($"Reserve Team: {team.ReserveTeam.Count}");
        }
    }
}