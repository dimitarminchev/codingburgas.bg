namespace PersonMoney
{
    /// <summary>
    /// Човек
    /// </summary>
    public class Person
    {
        private string? name;

        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private List<BankAccount> accounts;

        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public double GetBalance()
        {
            return accounts.Sum(a => a.Balance);
        }
    }
}