using System;
using System.Collections;
using Xunit;
using static BankApp.Bank;

namespace BankApp.UnitTests
{
    public class BankTests
    {
      
        [Fact]
        public void Deposit_IntoCheckingAccountCorrect()
        {
            Account acc1 = new Account(400, "Mike Johnson", "Checking");

            //Arrange
            float expected = 500;
            //Act
            acc1.deposit(100);
            //Assert
            Assert.Equal(expected, acc1.Balance);

        }

        [Fact]
        public void Deposit_IntoInvestmentAccountCorrect()
        {
            InvestmentAccount acc1 = new InvestmentAccount(400,"Chris Green",'C');

            //Arrange
            float expected = 500;
            //Act
            acc1.deposit(100);
            //Assert
            Assert.Equal(expected, acc1.Balance);

        }

        [Fact]
        public void Deposit_IntoCheckingAccountNegativeAmount()
        {
            Account acc1 = new Account(400, "Mike Johnson", "Checking");

            //Arrange
            float expected = 400;
            //Act
            acc1.deposit(-1);
            //Assert
            Assert.Equal(expected, acc1.Balance);
        }

        [Fact]
        public void Deposit_IntoInvestmentAccountNegativeAmount()
        {
            InvestmentAccount acc1 = new InvestmentAccount(400, "Chris Green", 'C');

            //Arrange
            float expected = 400;
            //Act
            acc1.deposit(-1);
            //Assert
            Assert.Equal(expected, acc1.Balance);

        }

        [Fact]
        public void Withdraw_fromAccount()
        {
            Account acc1 = new Account(400, "Mike Johnson", "Checking");

            //Arrange
            float expected = 0;
            //Act
            acc1.withdraw(400);
            //Assert
            Assert.Equal(expected, acc1.Balance);
        }

        [Fact]
        public void Withdraw_fromAccountOver()
        {
            Account acc1 = new Account(400, "Mike Johnson", "Checking");

            //Arrange
            float expected = 400;
            //Act
            acc1.withdraw(500);
            //Assert
            Assert.Equal(expected, acc1.Balance);
        }

        [Fact]
        public void Withdraw_fromInvestmentAccount()
        {
            InvestmentAccount acc1 = new InvestmentAccount(400, "Mike Johnson",'I');

            //Arrange
            float expected = 200;
            //Act
            acc1.withdraw(200);
            //Assert
            Assert.Equal(expected, acc1.Balance);
        }

        [Fact]
        public void Withdraw_fromInvestmentAccountOver()
        {
            InvestmentAccount acc1 = new InvestmentAccount(400, "Mike Johnson", 'I');

            //Arrange
            float expected = 400;
            //Act
            acc1.withdraw(500);
            //Assert
            Assert.Equal(expected, acc1.Balance);
        }

        [Fact]
        public void TransferMoneyfromCheckingToInvestmentIndividual()
        {
            Account acc1 = new Account(400, "Mike Johnson", "Checking");
            InvestmentAccount acc2 = new InvestmentAccount(100, "Chris Green", 'I');
            //Arrange
            float expected = 300;
            //Act
            acc1.transfer(acc2, 200);
            //Assert
            Assert.Equal(expected, acc2.Balance);
        }

        [Fact]
        public void TransferMoneyfromCheckingToInvestmentIndividualOverdraft()
        {
            Account acc1 = new Account(400, "Mike Johnson", "Checking");
            InvestmentAccount acc2 = new InvestmentAccount(100, "Chris Green", 'I');
            //Arrange
            float expected = 100;
            //Act
            acc1.transfer(acc2, 500);
            //Assert
            Assert.Equal(expected, acc2.Balance);
        }

        [Fact]
        public void TransferMoneyfromInvestmentIndividualToChecking()
        {
            Account acc1 = new Account(400, "Mike Johnson", "Checking");
            InvestmentAccount acc2 = new InvestmentAccount(100, "Chris Green", 'I');
            //Arrange
            float expected = 450;
            //Act
            acc2.transfer(acc1, 50);
            //Assert
            Assert.Equal(expected, acc1.Balance);
        }

        [Fact]
        public void TransferMoneyfromInvestmentIndividualToCheckingOverLimit()
        {
            Account acc1 = new Account(400, "Mike Johnson", "Checking");
            InvestmentAccount acc2 = new InvestmentAccount(600, "Chris Green", 'I');
            //Arrange
            float expected = 400;
            //Act
            acc2.transfer(acc1, 501);
            //Assert
            Assert.Equal(expected, acc1.Balance);
        }

        [Fact]
        public void TransferMoneyfromInvestmentCorporateToChecking()
        {
            Account acc1 = new Account(400, "Mike Johnson", "Checking");
            InvestmentAccount acc2 = new InvestmentAccount(600, "Chris Green", 'C');
            //Arrange
            float expected = 950;
            //Act
            acc2.transfer(acc1, 550);
            //Assert
            Assert.Equal(expected, acc1.Balance);
        }


    }
}
