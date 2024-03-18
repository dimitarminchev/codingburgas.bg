namespace Machine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            Airplane airplane = new Airplane();
            Truck truck = new Truck();

            MachineOperator mo = new MachineOperator(car);
            mo.Start(); 
            mo.Stop();

            mo.Entity = airplane; 
            mo.Start();
            mo.Stop();

            mo.Entity = truck;
            mo.Start();
            mo.Stop();

        }
    }
}
