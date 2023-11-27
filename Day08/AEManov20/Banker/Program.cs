namespace Banker;
class Program
{
    static void Main(string[] args)
    {
        // put bank accounts in bank class
        Bank.Add(1, 100);
        Bank.Add(2, 200);
        Bank.Add(3, 300);

        // withdraw from bank accounts
        Bank.Withdraw(1, 50);
        Bank.Withdraw(2, 20);
        Bank.Withdraw(3, 40);

        Bank.Print();
    }
}
