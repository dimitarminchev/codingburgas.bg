namespace PersonBankAccount
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
			set { id = value; }
		}

		private decimal balance;

		public decimal Balance
		{
			get { return balance; }
			set { balance = value; }
		}

	}
}
