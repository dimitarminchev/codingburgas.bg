namespace Machine
{
    public class Airplane : IMachine
    {
        public string MachineType { get; set; }

        public Airplane()
        {
            this.MachineType = "Airplane";
        }

        public bool Start()
        {
            Console.WriteLine("Airplane starting...");
            return true;

        }

        public bool Stop()
        {
            Console.WriteLine("Airplane stopping...");
            return true;
        }
    }
}
