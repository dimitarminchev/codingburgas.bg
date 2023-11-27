namespace Banker;

public static class Bank
{
    private static List<BankAccount> accounts = new();

    public static void Withdraw(int id, double amount)
    {
        BankAccount account = accounts.Find(a => a.ID == id);
        if (account == null)
        {
            throw new Exception("Account not found");
        }

        account.Withdraw(amount);
    }

    public static void Deposit(int id, double amount)
    {
        BankAccount account = accounts.Find(a => a.ID == id);
        if (account == null)
        {
            throw new Exception("Account not found");
        }

        account.Deposit(amount);
    }

    public static void Add(int id, double balance)
    {
        BankAccount account = accounts.Find(a => a.ID == id);
        if (account != null)
        {
            throw new Exception("Account already exists");
        }

        accounts.Add(new BankAccount()
        {
            ID = id,
            Balance = balance
        });
    }

    public static void Print()
    {
        foreach (BankAccount account in accounts)
        {
            Console.WriteLine(account.ToString());
        }
    }
}