using System;
using System.Collections.Generic;
using System.Text;
using AulaExcecoes.Exceptions;

namespace AulaExcecoes.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account() { }
        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;

        }

        public void WithDraw(double amount)
        {
            if (amount > WithDrawLimit)
            {
                throw new AccountExceptions("amount exceed the withdraw limit");
            }
            else if (amount > Balance)
            {
                throw new AccountExceptions("amount exceed the balance!");
            }
            else
            {
                Balance -= amount;
            }
        }
    }
}
