namespace CargoTransport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Truck> trucks = new List<Truck>();
            string[] truckInput = System.Console.ReadLine().Split(";").ToArray();
            foreach (var truck in truckInput)
            {
                string[] newTruck = truck.Split("=").ToArray();
                trucks.Add(new Truck() { Name = newTruck[0], WeightLimit = double.Parse(newTruck[1]) });
            }

            List<Freight> freights = new List<Freight>();
            string[] freightInput = System.Console.ReadLine().Split(";").ToArray();
            foreach (var freight in freightInput)
            {
                string[] newfreight = freight.Split("=").ToArray();
                freights.Add(new Freight() { Name = newfreight[0], Weight = double.Parse(newfreight[1]) });
            }

            string input = System.Console.ReadLine();
            while (input != "END")
            {
                string[] line = input.Split().ToArray();

                try
                {
                    Truck truck = trucks.FirstOrDefault(x => x.Name == line[0]);
                    Freight freight = freights.FirstOrDefault(x => x.Name == line[1]);

                    truck.Load(freight);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                input = System.Console.ReadLine();
            }

            foreach (var truck in trucks)
            {
                string[] freight = truck.Freights.Select(x => x.Name).ToArray();

                if (freight.Count() == 0)
                {
                    Console.WriteLine(truck.Name + " - Nothing loaded");
                }
                else
                {
                    Console.WriteLine(truck.Name + " - " + String.Join(", ", freight));
                }
            }
        }
    }
}