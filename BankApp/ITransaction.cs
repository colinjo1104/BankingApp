using System;
namespace BankApp
{
    public interface ITransaction
    {
        void deposit(float amount);
        void withdraw(float amount);
        void transfer(Account account, float amount);
    }
}
