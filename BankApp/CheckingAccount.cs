using System;
namespace BankApp
{
    public class CheckingAccount:Account
    {
        public CheckingAccount()
        {

        }
        public CheckingAccount(float balance, string owner): base(balance,owner)
        {
            
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
            if (this.Balance >= amount)
            {
                this.Balance = this.Balance - amount;
                dest.Balance = dest.Balance + amount;
            }
            else
                Console.WriteLine("Cannot Transfer perform transfer Insufficient funds!");
        }

        public override void withdraw(float amount)
        {
            // Check to see if withdrawl amount is more than current balance
            if (amount <= this.Balance)
                this.Balance = this.Balance - amount;
            else
                Console.WriteLine("Withdrawal amount exceeds current balance");
        }
    }
}
