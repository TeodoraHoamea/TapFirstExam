using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForExam
{
    public abstract class Account : IAccount
    {
        //ctrl+R+I pentru a crea interfata
        public decimal Balance { get; private set; }

        public void Deposite(decimal ammount)
        {
            this.Balance += ammount;
        }

        public decimal withdraw(decimal ammout)
        {
            var fee = Calculatewithdraw(ammout);
            ammout = ammout + fee;
            if (Balance < ammout)
                throw new InvalidOperationException("Insufficient Funds!!!!");
            else
                this.Balance -= ammout;
            return ammout;
        }

        protected abstract decimal Calculatewithdraw(decimal ammount);
    }
}
