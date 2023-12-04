namespace Shop;

class Program
{
    static void Main(string[] args)
    {
        string input = System.Console.ReadLine()!;

        while (input != "Close")
        {
            string[] command = input.Split(' ');

            switch (command[0])
            {
                case "Sell":
                    try
                    {
                        ShopManager.Sell(command[1], double.Parse(command[2]));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "Add":
                    try
                    {
                        ShopManager.Add(command[1], command[2], double.Parse(command[3]), double.Parse(command[4]));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "Update":
                    try
                    {
                        ShopManager.Update(command[1], double.Parse(command[2]));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "PrintA":
                    ShopManager.PrintAvailable();
                    break;
                case "PrintD":
                    ShopManager.PrintDescending();
                    break;
                case "PrintU":
                    ShopManager.PrintUnavailable();
                    break;
                case "Calculate":
                    Console.WriteLine(ShopManager.Calculate().ToString());
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }

            input = System.Console.ReadLine()!;
        }
    }
}
