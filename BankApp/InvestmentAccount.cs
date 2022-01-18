using System;
namespace BankApp
{
    public class InvestmentAccount:Account
    {
        private char _investmentAccountType;

        //default constructor
        public InvestmentAccount()
        {

        }
        public InvestmentAccount(float balance, string owner,char investType) : base(balance, owner)
        {
            _investmentAccountType = investType;
        }

        public char AccountType
        { 
            get { return _investmentAccountType; }
            set { _investmentAccountType = value; }
        }

        public override void withdraw(float amount)
        {
            //Check to see if withdrawl amount is more than current balance
            if (amount <= this.Balance)
            {
                if (isIndividual() && amount <= 500)
                    this.Balance = this.Balance - amount;
                else if (isIndividual() && amount > 500)
                    Console.WriteLine("Individual accounts cannot withdraw more than $500");
                else
                    this.Balance = this.Balance - amount;
            }
            else
                Console.WriteLine("Withdrawal amount exceeds current balance");
        }

        public bool isIndividual()
        {
            if (this._investmentAccountType == 'I')
                return true;
            else
                return false;
        }

        public override void deposit(float amount)
        {
            if (amount > 0)
                this.Balance += amount;
            else
                Console.WriteLine("Deposit must be greater than 0");
        }

        public override void transfer(Account dest, float amount)
        {
            if (isIndividual())
            {
                if (this.Balance >= amount && amount <= 500)
                {
                    this.Balance = this.Balance - amount;
                    dest.Balance = dest.Balance + amount;
                }
                else
                    Console.WriteLine("Cannot perform transfer due to insufficent funds or Transfer on Individual account exceeding $500");
            }
            else
            {
                if (this.Balance >= amount)
                {
                    this.Balance = this.Balance - amount;
                    dest.Balance = dest.Balance + amount;
                }
                else
                Console.WriteLine("Cannot Transfer perform transfer Insufficient funds!");
            }
        }
    }
}
