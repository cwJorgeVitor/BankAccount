using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectBankAccount.Entities.Exceptions;

namespace ProjectBankAccount.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if(balance < 0)
            {
                throw new AccountException("error! Withdrawal amount cannot be greater than 0.0");
            }

            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > Balance && amount > WithdrawLimit)
            {
                throw new AccountException("error! Withdraw amount cannot exceed the stipulated limit");
            }

            if (amount > Balance)
            {
                throw new AccountException("error! Withdraw amount cannot exceed the balance");
            }

            if (amount > WithdrawLimit)
            {
                throw new AccountException("error! Withdraw amount cannot exceed the stipulated limit");
            }

            Balance -= amount;
        }
    }
}
