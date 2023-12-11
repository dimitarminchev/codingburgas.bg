using NUnit.Framework;

namespace BankAccountNunitTests
{
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void DepositShouldAddMoney()
        {
            // Arrange
            BankAccount.BankAccount account = new BankAccount.BankAccount();

            // Act
            account.Deposit(100);

            // Assert
            Assert.IsTrue(account.Balance == 100);
        }

        [Test]
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

        [Test]
        public void NegativeBalanceShoudThrowExeption()
        {
            // Arrange
            BankAccount.BankAccount account = new BankAccount.BankAccount();

            // Act 
            ArgumentException exception = Assert.Throws<ArgumentException>(() => account.Balance = -1);

            // Assert
            Assert.That(exception.Message, Is.EqualTo("Balance must be zero or positive!"));
        }

        [Test]
        public void BalanceSetCorrectId()
        {
            // Arrange
            BankAccount.BankAccount account = new BankAccount.BankAccount();

            // Act
            account.Id = 100;

            // Assert
            Assert.IsTrue(account.Id == 100);
        }

        [Test]
        public void NegativeIdShoudThrowExeption()
        {
            // Arrange
            BankAccount.BankAccount account = new BankAccount.BankAccount();

            // Act 
            ArgumentException exception = Assert.Throws<ArgumentException>(() => account.Id = -1);

            // Assert
            Assert.That(exception.Message, Is.EqualTo("Id must be positive!"));
        }
    }
}