namespace RandomList
{
    public class Program
    {
        static void Main(string[] args)
        {
            RandomList rand = new RandomList();

            // Добавяме пет елемента към колекцията
            rand.Add("one");
            rand.Add("two");
            rand.Add("three");
            rand.Add("four");
            rand.Add("five");

            // Извеждаме три слчайни елемента от колекцията
            Console.WriteLine(rand.RandomString());
            Console.WriteLine(rand.RandomString());
            Console.WriteLine(rand.RandomString());
        }
    }
}
