using System;
using System.Collections;

namespace BankApp
{
    public class Bank
    {
        //name of bank
        public string bankName;
        //list of accounts
        public ArrayList accounts;

        //default constructor
        public Bank()
        {
            bankName = null;
            accounts = null;
        }
        public Bank(string bankName, ArrayList list)
        {
            this.bankName = bankName;
            this.accounts = list;
        }

    }
}
