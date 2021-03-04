using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppForExam
{
    public class ATM
    {
        private static ATM _instance;
        private Card _card;
        private Account _account;
        private ATM()
        {
            Console.WriteLine("New Instance of ATM");
        }
        public static ATM Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ATM();

                }
                return _instance;
            }
        }

        public void Insert(Card card) {
            _card = card;

        }

        public void SelectAccount(Account account) {
            var acc = _card.Accounts.Single(a => a == account);
            _account = account;
           
        }

        public void withdraw(decimal ammount) {
            _account.withdraw(ammount);
            Console.WriteLine($"Account {ammount} was withdraw for the account");
            Console.WriteLine($"Remaining {_account.Balance}");
        }

        public void Eject(Card card) { 

        }
    }
} 
