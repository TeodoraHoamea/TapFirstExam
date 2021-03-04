using System;

namespace ConsoleAppForExam
{
    class Program
    {
       static void Main(string[] args)
       {
            var Acc = new SavingsAccount();

            Acc.Deposite(200);

            var card = new Card("Nume Random");
            card.AddAccount(Acc);

            ATM.Instance.Insert(card);
            ATM.Instance.SelectAccount(Acc);
            ATM.Instance.withdraw(100);
            /*Console.WriteLine($"Your Deposite contains {Acc.Balance} RON");
            try
            {
                Acc.withdraw(100);
            }catch(InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"Your Deposite contains {Acc.Balance} RON");*/
       }
    }
}
