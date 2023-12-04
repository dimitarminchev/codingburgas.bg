namespace Banker;

public class BankAccount
{
    private int id;
    public int ID
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
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        balance -= amount;
    }

    public override string ToString()
    {
        return $"Account {id} has balance {balance}";
    }
}