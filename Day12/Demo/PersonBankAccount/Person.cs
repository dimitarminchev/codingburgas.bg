namespace PersonBankAccount
{
	/// <summary>
	/// Човек
	/// </summary>
    public class Person
    {
		private string name;

		public string Name
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

        private List<BankAccount> accounts = new List<BankAccount>();

        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

		public decimal GetBalances()
		{
			return accounts.Sum(x => x.Balance);
		}
    }
}
