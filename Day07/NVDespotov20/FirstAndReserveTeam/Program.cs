namespace FirstAndReservedTeam;
public class Program
{
    public static void Main(string[] args)
    {
        //Data
        Team team = new Team("CodingBurgas");
        //Input.txt
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; ++i)
        {
            string[] line = Console.ReadLine().Split().ToArray();
            //line[0] = FirstName, line[1] = LastName, line[2] = age, line[3] = salary
            
            team.AddPlayer(new Person{
                FirstName = line[0],
                LastName = line[1],
                age = int.Parse(line[2]),
                salary = double.Parse(line[3])
            });
        }
        //Output.txt
        Console.WriteLine($"First team has {team.FirstTeam.Count} players");
        Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players");
    }
}
