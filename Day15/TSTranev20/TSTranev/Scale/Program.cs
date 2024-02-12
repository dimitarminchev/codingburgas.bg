namespace Scale
{
    public class Program
    {
        static void Main(string[] args)
        {
            Scale<int> intScale = new Scale<int>(100, 50);
            Console.WriteLine(intScale.GetHeavier());

            Scale<string> strScale = new Scale<string>("Siriq", "Afganistan");
            Console.WriteLine(strScale.GetHeavier()); 

            Scale<int> intScale2 = new Scale<int>(10, 10);
            Console.WriteLine(intScale2.GetHeavier());

            Scale<string> strScale2 = new Scale<string>("Yes", "No");
            Console.WriteLine(strScale2.GetHeavier());
        }
    }
}