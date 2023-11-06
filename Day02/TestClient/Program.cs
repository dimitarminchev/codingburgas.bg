namespace TestClient
{
    public class Program
    {
        // Бнкови акаунти
        private static List<BankAccount> accounts = new List<BankAccount>();

        static void Main(string[] args)
        {
            // Input
            string line = System.Console.ReadLine();
            while (line != "End")
            {
                string[] param = line.Split();
                switch (param[0]) // 0 = Create, Deposit, Withdraw, Print
                {
                    case "Create":
                        {
                            var account = accounts.Where(x => x.Id == int.Parse(param[1])).FirstOrDefault();
                            if (account != null)
                            {
                                Console.WriteLine("Account already exists");
                            }
                            else
                            {
                                accounts.Add(new BankAccount
                                {
                                    Id = int.Parse(param[1]), // 1 = id
                                    Balance = 0
                                });
                            }
                            break;
                        }

                    case "Deposit":
                        {
                            var account = accounts.Where(x => x.Id == int.Parse(param[1])).FirstOrDefault();
                            if (account == null)
                            {
                                Console.WriteLine("Account does not exist");
                            }
                            else 
                            {
                                account.Deposit(int.Parse(param[2]));
                            }
                            break;
                        }

                    case "Withdraw":
                        {
                            var account = accounts.Where(x => x.Id == int.Parse(param[1])).FirstOrDefault();
                            if (account == null)
                            {
                                Console.WriteLine("Account does not exist");
                            }
                            else if (int.Parse(param[2]) > account.Balance)
                            {
                                Console.WriteLine("Insufficient balance");
                            }
                            else 
                            {
                                account.Withdraw(int.Parse(param[2]));
                            }
                            break;
                        }

                    case "Print":
                        {
                            var account = accounts.Where(x => x.Id == int.Parse(param[1])).FirstOrDefault();
                            if (account == null)
                            {
                                Console.WriteLine("Account does not exist");
                            }
                            else 
                            {
                                Console.WriteLine(account.ToString());
                            }
                            break;
                        }
                }
                line = System.Console.ReadLine();
            }
        }
    }
}