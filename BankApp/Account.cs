using System;
namespace BankApp
{
    public class Account
    {
        //class properties
        public float _balance;
        public string _owner;
        public string _type;

        //default constructor
        public Account()
        {
           

        }

        public Account(float balance, string owner, string type)
        {
            _balance = balance;
            _owner = owner;
            _type = type;
        }

        public float Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public virtual void deposit(float amount)
        {
            if (amount > 0)
                _balance += amount;
            else
                Console.WriteLine("Deposit must be greater than 0");
        }

        public virtual void withdraw(float amount)
        {
            if (this.validBalance() && amount <= _balance)
                _balance -= amount;
            else
                Console.WriteLine("Insufficient funds!");

        }
        //checks to see if balance is less than 0
        public bool validBalance()
        {
            if (_balance > 0)
                return true;
            else
                return false;
        }

        public virtual void transfer(Account dest, float amount)
        {

            if (this.Balance >= amount)
            {
                this.Balance = this.Balance - amount;
                dest.Balance = dest.Balance + amount;
            }
            else
            {
                Console.WriteLine("Cannot Transfer perform transfer Insufficient funds!");
            }
        }

       public virtual void transfer(InvestmentAccount dest, float amount)
        {

            if (this.Balance >= amount)
            {
                this.Balance = this.Balance - amount;
                dest.Balance = dest.Balance + amount;
            }
            else
            {
                Console.WriteLine("Cannot Transfer perform transfer Insufficient funds!");
            }







        }
    }
}