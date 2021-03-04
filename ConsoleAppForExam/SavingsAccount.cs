using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForExam
{
    public class SavingsAccount:Account
    {
        protected override decimal Calculatewithdraw(decimal ammount)
        {
            return ammount * 0.5m / 100m;
        }
    }
}
