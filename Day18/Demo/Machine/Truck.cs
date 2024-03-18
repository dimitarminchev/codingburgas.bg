﻿namespace Machine
{
    public class Truck : IMachine
    {
        public string MachineType { get; set; }

        public Truck()
        {
            this.MachineType = "Truck";
        }

        public bool Start()
        {
            Console.WriteLine("Truck starting...");
            return true;

        }

        public bool Stop()
        {
            Console.WriteLine("Truck stopping...");
            return true;
        }
    }
}
