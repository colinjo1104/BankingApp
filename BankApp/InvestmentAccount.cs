using System;
namespace BankApp
{
    public class InvestmentAccount:Account
    {
        private char _investmentAccountType;

        public InvestmentAccount()
        {

        }
      

        public InvestmentAccount(string owner, float balance, char investType) 
        {
            _owner = owner;
            _balance = balance;
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

        public override void transfer(InvestmentAccount dest, float amount)
        {
            if (isIndividual() && amount > 500)
                Console.WriteLine("Individual investment accounts cannot transfer more then $500");
            else
                base.transfer(dest, amount);

        }
        public override void transfer(Account dest, float amount)
        {
            if (isIndividual() && amount > 500)
                Console.WriteLine("Individual investment accounts cannot transfer more then $500");
            else
                base.transfer(dest, amount);

        }


    }
}
