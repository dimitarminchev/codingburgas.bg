using System.Linq;

namespace CargoTransport
{
    public class Truck
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double weightLimit;

        public double WeightLimit
        {
            get { return weightLimit; }
            set { weightLimit = value; }
        }

        private List<Freight> freights = new List<Freight>();

        public List<Freight> Freights
        {
            get { return freights; }
            set { freights = value; }
        }

        public void Load(Freight freight)
        {
            double sum = freights.Sum(x => x.Weight);

            if(sum + freight.Weight < WeightLimit)
            {
                freights.Add(freight);
                Console.WriteLine($"{Name} loaded {freight.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} can't loaded {freight.Name}");
            }
        }

    }
}