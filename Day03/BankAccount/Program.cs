using System;

namespace BankAccount
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();

            acc.ID = 1;
            acc.Balance = 15;

            Console.WriteLine($"Account {acc.ID}, balance {acc.Balance}");
        }
    }
}
