namespace Machine
{
    public class MachineOperator : IMachine
    {
        public string MachineType { get; set; }

        private IMachine entity;

        public IMachine Entity
        {
            get { return this.entity; }
            set
            {
                this.entity = value;
                Console.WriteLine("Machine operator is operating: " + value.MachineType);
            }
        }
        public MachineOperator(IMachine entity)
        {
            this.Entity = entity;
        }

        public bool Start()
        {
            return Entity.Start();
        }

        public bool Stop()
        {
            return Entity.Stop();
        }
    }
}
