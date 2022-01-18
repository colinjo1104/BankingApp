using System;
namespace BankApp
{
    public abstract class Account : ITransaction
    {
        //class properties
        public float _balance;
        public string _owner;
    

        //default constructor
        public Account()
        {
           

        }

        public Account(float balance, string owner)
        {
            _balance = balance;
            _owner = owner;   
        }

        
        public float Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public abstract void deposit(float amount);


        public abstract void withdraw(float amount);

        public abstract void transfer(Account dest, float amount);

        //checks to see if balance is less than 0
        public bool validBalance()
        {
            if (_balance > 0)
                return true;
            else
                return false;
        }

    }
}