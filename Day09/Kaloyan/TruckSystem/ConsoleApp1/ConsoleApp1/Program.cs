using System.Diagnostics;

namespace TruckSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            List<Truck> trucks = new List<Truck>();
            string[] truckInput = Console.ReadLine().Split(";").ToArray();
            foreach (string input in truckInput)
            {
                string[] newInput = input.Split("=").ToArray();
                trucks.Add(new Truck { Name = newInput[0], LoadCapacity = double.Parse(newInput[1]) });
            }

            List<Freight> freights = new List<Freight>();
            string[] freightInput = Console.ReadLine().Split(";").ToArray();
            foreach (string input in freightInput)
            {
                string[] newInput = input.Split("=").ToArray();
                freights.Add(new Freight { Name = newInput[0], Weight = double.Parse(newInput[1]) });
            }

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                string[] input = Console.ReadLine().Split(" ").ToArray();

                if (input[0] == "END")
                {
                    break;
                }

                foreach (Truck truck in trucks)
                {
                    if (truck.Name == input[0])
                    {
                        foreach (Freight freight in freights)
                        {
                            if (freight.Name == input[1])
                            {
                                truck.Load(freight);
                                break;
                            }
                        }
                        break;
                    }
                }
            }

            foreach (Truck truck in trucks)
            {
                truck.ShowLoadedFreights();
            }
        }
    }
}