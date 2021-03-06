﻿using Contract.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Model
{
    public class Account 
    {
        private string number;
        private long balance = 0;
        private Bank bank;

        public string Number { get { return number; } set { number = value; } }
        public long Balance { get { return balance; } set { balance = value; } }


        public Account(string number)
        {
            this.number = number;
        }

        public long getBalance()
        {
            return balance;
        }


        public void Transfer(long amount, IAccount target)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount is negative");
            }
            Balance -= amount;
            target.Balance += amount;
        }

        public void Transfer(long amount, string targetNumber)
        {
            if (balance < 0)
            {
                throw new ArgumentException("Amount is negative");
            }
            IAccount target = bank.GetAccount(targetNumber);
            Transfer(amount, target);
        }

        //public void Deposit(IAccount target, long amount)
        //{
        //    target.Balance += amount;
        //}

        //public void Withdrawal(long amount, IAccount target)
        //{
        //    target.Balance -= amount;
        //}
    }
}
