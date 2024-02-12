namespace Scale
{

    public class Program
    {
        static void Main(string[] args)
        {
            // Сравняване на цели числа [9..0]
            Scale<int> intScale = new Scale<int>(5, 10);
            Console.WriteLine( intScale.GetHeavier() ); 

            // Сравняване на текстови низове [A..Z]
            Scale<string> strScale = new Scale<string>("Alabama", "Colorado");
            Console.WriteLine(strScale.GetHeavier()); // Colorado

            // Сравняване на цели числа [9..0]
            Scale<int> intScale2 = new Scale<int>(42, 42);
            Console.WriteLine(intScale2.GetHeavier()); // default => 0

            // Сравняване на текстови низове [A..Z]
            Scale<string> strScale2 = new Scale<string>("Hi", "Hi");
            Console.WriteLine(strScale2.GetHeavier()); // default => null
        }
    }
}
