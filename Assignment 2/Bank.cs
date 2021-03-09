using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Bank
    {
        private string bankName;
        private Account[] myBank;

        public Bank(string bankName, int size)
        {
            this.bankName = bankName;
            this.myBank = new Account[size];
        }

        public string BankName
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }

        public Account[] MyBank
        {
            get { return this.myBank; }
        }
        public void AddAccount(Account account)
        {
            
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    
                }
            }
            Console.WriteLine("ACCOUNT ADDED\ntYour Account Number = {0} ", myBank[num].AccountNumber);
        }


        public void Transaction()
        {
            
        }
        public void PrintAccountDetails()
        {
            Console.WriteLine("Bank Name : " + this.bankName);

        }
    }
}