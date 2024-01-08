namespace PersonBankAccount
{
	/// <summary>
	/// Човек
	/// </summary>
    public class Person
    {
		private string name;

		/// <summary>
		/// Име
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private int age;

		/// <summary>
		/// Възраст
		/// </summary>
		public int Age
		{
			get { return age; }
			set { age = value; }
		}

        private List<BankAccount> accounts = new List<BankAccount>();

		/// <summary>
		/// Банкови сметки на човечето
		/// </summary>
        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

		/// <summary>
		/// Сума на парите по всички сметки
		/// </summary>
		public decimal GetBalances()
		{
			return accounts.Sum(x => x.Balance);
		}
    }
}
