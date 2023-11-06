namespace BankAccount
{
    /// <summary>
    /// Главна програма
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.Id = 1;
            account.Deposit(15);
            account.Withdraw(15);

            Console.WriteLine(account.ToString());
        }
    }
}