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
        public InvestmentAccount(float balance, string owner, char investType) 
        {
            _balance = balance;
            _owner = owner; 
            _investmentAccountType = investType;
            _type = "InvestmentAccount";    
        }

        public char Type
        {
            get { return _investmentAccountType; }
            set { _investmentAccountType = value; }
        }

        public override void withdraw(float amount)
        {
            if (isIndividual() && amount <= 500)
                base.withdraw(amount);
            else if (!isIndividual())
                base.withdraw(amount);     
        }

        public bool isIndividual()
        {
            if (this._investmentAccountType == 'I')
                return true;
            else
                return false;
        }
        //transfer from Investment account to Investment account
        public override void transfer(InvestmentAccount dest, float amount)
        {
            if (isIndividual() && amount > 500)
                Console.WriteLine("Individual investment accounts cannot transfer more then $500");
            else
                base.transfer(dest, amount);

        }
        //transfer from Investment to Checking account
        public override void transfer(Account dest, float amount)
        {
            if (isIndividual() && amount > 500)
                Console.WriteLine("Individual investment accounts cannot transfer more then $500");
            else
                base.transfer(dest, amount);

        }


    }
}
