using System;
using System.Collections;
using System.Collections.Generic;

namespace BankApp
{
    public class Bank
    {
        //name of bank
        public string bankName;
        //list of accounts
        public List <Account> accounts;

        //default constructor
        public Bank()
        {
            bankName = null;
            accounts = null;
        }
        public Bank(string bankName, List<Account> list)
        {
            this.bankName = bankName;
            this.accounts = list;
        }

    }
}
