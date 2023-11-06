namespace PersonMoney
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person ivan = new Person
            {
                Name = "Ivan",
                Age = 23,
                Accounts = new List<BankAccount>
                {
                    new BankAccount { Id = 1, Balance = 100 },
                    new BankAccount { Id = 2, Balance = 200 },
                    new BankAccount { Id = 3, Balance = 300 }
                }
            };

            foreach (var account in ivan.Accounts) 
            {
                Console.WriteLine(account.ToString());
            }

            Console.WriteLine("Total balance = {0}", ivan.GetBalance());
        }
    }
}