namespace TestClient
{
    /// <summary>
    /// Банкова сметка
    /// </summary>
    public class BankAccount
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(double amount)
        { 
            Balance += amount;
        }

        public void Withdraw(double amount) 
        { 
            Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account {Id}, balance {Balance}";
        }
    }
}