using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleAppForExam
{
    public class DepositAccount : Account
    {
        protected override decimal Calculatewithdraw(decimal ammount)
        {
            return 0m;
        } 
    }
}
