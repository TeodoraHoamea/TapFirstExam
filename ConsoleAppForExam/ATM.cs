using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForExam
{
    public class ATM
    {
        private static ATM _instance;
        
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
    }
} 
