namespace CarRide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++) 
            {
                string[] line = Console.ReadLine().Split(' ').ToArray();
                Car car = new Car(line[0], double.Parse(line[1]), double.Parse(line[2]), 0);
                cars.Add(car);
            }
            string[] line1 = Console.ReadLine().Split(' ').ToArray();
            while (line1[0] != "End") 
            {
                foreach (Car car in cars) 
                {
                    if (car.Model == line1[1]) 
                    {
                        car.Drive(int.Parse(line1[2]));
                    }
                }
                line1 = Console.ReadLine().Split(' ').ToArray();
            };
            foreach (Car car in cars) 
            {
                car.EndPrint(car.Model);
            }
        }
    }
}