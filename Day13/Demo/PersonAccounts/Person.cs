namespace PersonAccounts
{
    public class Person
    {
        private static int counter = 0;

        public static int Counter
        {
            get { return counter; }
        }

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

        private List<BankAccount> accounts;

        public List<BankAccount> Accounts
        {
            get { return this.accounts; }
            set { this.accounts = value; }
        }

        public Person(string name, int age) : this(name, age, new List<BankAccount>())
        {
            ;; 
        }

        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.name = name;
            this.age = age;
            this.accounts = accounts;

            counter++;
        }

        public override string ToString()
        {
            decimal totalBalance = this.accounts.Sum(a => a.Balance);
            return $"Total Balance {totalBalance}";
        }
    }
}
