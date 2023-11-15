namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carNum = int.Parse(Console.ReadLine());

            List<Car> car = new List<Car>();

            for (int i = 0; i < carNum; i++)
            {
                string[] getCar = Console.ReadLine().Split(' ').ToArray();

                Car setCar = new Car(getCar[0], double.Parse(getCar[1]), double.Parse(getCar[2]), 0);
                car.Add(setCar);
            }

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                string[] testDrive = Console.ReadLine().Split(' ').ToArray();

                if (testDrive[0] == "End")
                {
                    break;
                }

                for(int i = 0; i < carNum; i++)
                {
                    if (car[i].model == testDrive[1])
                    {
                        car[i].Drive(int.Parse(testDrive[2]));
                        break;
                    }
                }
            }

            for (int i = 0; i < carNum; i++)
            {
                car[i].OutputCar();
            }
        }
    }
}