namespace PersonAccounts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Person Counter
            Console.WriteLine($"Person Counter = {Person.Counter}");


            // Person Pesho
            Person pesho = new Person("Pesho", 23, new List<BankAccount>()
            {
                new BankAccount() { Id = "1", Balance = 15 },
                new BankAccount() { Id = "2", Balance = 20 },
                new BankAccount() { Id = "3", Balance = 25 },
            });
            Console.WriteLine($"Person name: {pesho.Name}");
            foreach (var account in pesho.Accounts)
            {
                Console.WriteLine(account.ToString());
            }
            Console.WriteLine(pesho.ToString());


            // Person Counter
            Console.WriteLine($"Person Counter = {Person.Counter}");


            // Person Ivan
            Person ivan = new Person("Ivan", 32, new List<BankAccount>()
            {
                new BankAccount() { Id = "1", Balance = 35 },
                new BankAccount() { Id = "2", Balance = 12 },
            });
            Console.WriteLine($"Person name: {ivan.Name}");
            foreach (var account in ivan.Accounts)
            {
                Console.WriteLine(account.ToString());
            }
            Console.WriteLine(ivan.ToString());

            // Person Counter
            Console.WriteLine($"Person Counter = {Person.Counter}");
        }
    }
}
