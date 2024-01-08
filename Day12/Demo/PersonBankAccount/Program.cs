namespace PersonBankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(new BankAccount { Id = 1, Balance = 100 });
            bankAccounts.Add(new BankAccount { Id = 2, Balance = 200 });
            bankAccounts.Add(new BankAccount { Id = 3, Balance = 300 });

            Person ivan = new Person();
            ivan.Name = "Ivan";
            ivan.Age = 18;
            ivan.Accounts = bankAccounts;

            Console.WriteLine("Total = {0}", ivan.GetBalances());
        }
    }
}
