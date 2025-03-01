using System;
using NUnit.Framework;
using Banking;

namespace BankingTest
{
    [TestFixture]
    public class BankAccountTest
    {
        private BankAccount account;

        [SetUp]
        public void SetUp()
        {
            account = new BankAccount(100); // Initialize account with $100
        }

        [Test]
        public void Deposit_ShouldIncreaseBalance()
        {
            account.Deposit(50);
            Assert.AreEqual(150, account.GetBalance(), "Balance should increase after deposit.");
        }

        [Test]
        public void Withdraw_ShouldDecreaseBalance()
        {
            bool result = account.Withdraw(40);
            Assert.IsTrue(result, "Withdrawal should be successful.");
            Assert.AreEqual(60, account.GetBalance(), "Balance should decrease after withdrawal.");
        }

        [Test]
        public void Withdraw_InsufficientFunds_ShouldFail()
        {
            bool result = account.Withdraw(200);
            Assert.IsFalse(result, "Withdrawal should fail due to insufficient funds.");
            Assert.AreEqual(100, account.GetBalance(), "Balance should remain unchanged.");
        }

        [Test]
        public void GetBalance_ShouldReturnCorrectBalance()
        {
            Assert.AreEqual(100, account.GetBalance(), "Initial balance should be correct.");
        }

        [Test]
        public void Deposit_NegativeAmount_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => account.Deposit(-10), "Negative deposit should throw exception.");
        }

        [Test]
        public void Withdraw_NegativeAmount_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => account.Withdraw(-10), "Negative withdrawal should throw exception.");
        }

        [Test]
        public void InitializeAccount_NegativeBalance_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => new BankAccount(-50), "Account cannot be initialized with a negative balance.");
        }
    }
}
