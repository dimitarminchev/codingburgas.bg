namespace CarAdventure
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            Car[] cars = new Car[100];

            string[] carInfo, commandLine;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                carInfo = Console.ReadLine().Split(" ").ToArray();

                cars[i] = new Car(carInfo[0], double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            }

            commandLine = Console.ReadLine().Split(" ").ToArray();

            while (commandLine[0] != "End")
            {
                for (int i = 0; i < n; i++)
                {
                    if (commandLine[0] == "Drive" && cars[i].Model == commandLine[1])
                    {
                        cars[i].drive(double.Parse(commandLine[2]));
                    }
                }
                commandLine = Console.ReadLine().Split(" ").ToArray();
            }

            for (int i = 0; i < n; i++)
            {
                cars[i].printCarInfo();
            }
        }
    }
}