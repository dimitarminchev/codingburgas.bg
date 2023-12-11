using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankAccountMicrosoftTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void DepositShouldAddMoney()
        {
            // Arrange
            BankAccount.BankAccount account = new BankAccount.BankAccount();

            // Act
            account.Deposit(100);

            // Assert
            Assert.IsTrue(account.Balance == 100);
        }

        [TestMethod]
        public void WithdrawShouldRemoveMoney()
        {
            // Arrange
            BankAccount.BankAccount account = new BankAccount.BankAccount();

            // Act
            account.Deposit(100);
            account.Withdraw(100);

            // Assert
            Assert.IsTrue(account.Balance == 0);
        }

        [TestMethod]
        public void NegativeBalanceShoudThrowExeption()
        {
            // Arrange
            BankAccount.BankAccount account = new BankAccount.BankAccount();

            // Act 
            ArgumentException exception = Assert.ThrowsException<ArgumentException>(() => account.Balance = -1);

            // Assert
            Assert.AreEqual(exception.Message, "Balance must be zero or positive!");
        }

        [TestMethod]
        public void BalanceSetCorrectId()
        {
            // Arrange
            BankAccount.BankAccount account = new BankAccount.BankAccount();

            // Act
            account.Id = 100;

            // Assert
            Assert.IsTrue(account.Id == 100);
        }

        [TestMethod]
        public void NegativeIdShoudThrowExeption()
        {
            // Arrange
            BankAccount.BankAccount account = new BankAccount.BankAccount();

            // Act 
            ArgumentException exception = Assert.ThrowsException<ArgumentException>(() => account.Id = -1);

            // Assert
            Assert.AreEqual(exception.Message, "Id must be positive!");
        }
    }
}