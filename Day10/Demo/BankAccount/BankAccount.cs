namespace BankAccount
{
    /// <summary>
    /// Банкова сметка
    /// </summary>
    public class BankAccount
    {
        private int id;

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id
        {
            get { return id; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Id must be positive!");
                }
                id = value; 
            }
        }

        private decimal balance;

        /// <summary>
        /// Баланс
        /// </summary>
        public decimal Balance
        {
            get { return balance; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance must be zero or positive!");
                }
                balance = value; 
            }
        }

        /// <summary>
        /// Депозира сума в банковата сметка
        /// </summary>
        /// <param name="amount">Сума на депозита</param>
        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        /// <summary>
        /// Изтегляне на сума от банковата сметка
        /// </summary>
        /// <param name="amount">Сума за изтегляне</param>
        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }
    }
}
