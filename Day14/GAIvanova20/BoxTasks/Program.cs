namespace BoxTasks
{
    public partial class Program
    {
        private static void secondTask() {
            Box<int> boxInt = new Box<int>(123123);
            Box<string> boxStr = new Box<string>("life in a box");

            Console.WriteLine(boxInt.ToString());
            Console.WriteLine(boxStr.ToString());
        }

        private static void thirdTask() {
            int strCount = int.Parse(Console.ReadLine());
            Box<string> []currentStr = new Box<string>[strCount];

            for (int i = 0; i < strCount; i++)
            {
                currentStr[i] = new Box<string>(Console.ReadLine());
            }

            for (int i = 0; i < strCount; i++)
            {
                Console.WriteLine(currentStr[i].ToString());
            }
        }

        private static void forthTask() {
            int numberCount = int.Parse(Console.ReadLine());
            Box<int> numbers;


            for (int i = 0; i < numberCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers = new Box<int>(number);
                Console.WriteLine(numbers.ToString());
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Second task:");
            secondTask();

            Console.WriteLine("Third task:");
            thirdTask();

            Console.WriteLine("Forth task:");
            forthTask();
        }
    }
}