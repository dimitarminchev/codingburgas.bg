namespace BankAccount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Arrange
            BankAccount account = new BankAccount();

            // Act
            account.Deposit(100);

            // Assert
            Console.WriteLine(account.Balance);
        }
    }
}
