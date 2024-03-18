namespace Machine
{
    public class Car : IMachine
    {
        public string MachineType { get; set ; }

        public Car()
        {
            this.MachineType = "Car";
        }

        public bool Start()
        {
            Console.WriteLine("Car starting...");
            return true;

        }

        public bool Stop()
        {
            Console.WriteLine("Car stopping...");
            return true;
        }
    }
}
