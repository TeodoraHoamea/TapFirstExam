using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForExam
{
    class TestAccount : IAccount
    {
        public decimal Balance => throw new NotImplementedException();

        public void Deposite(decimal ammount)
        {
            throw new NotImplementedException();
        }
        public decimal withdraw(decimal ammount)
        {
            throw new NotImplementedException();
        }
    }
}
