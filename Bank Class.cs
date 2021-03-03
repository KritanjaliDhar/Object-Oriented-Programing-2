using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Bank
    {
        private string bankName;
        private Account[] myBank;

        public Bank(string bankName, Account[] myBank)
        {

            this.bankName = bankName;
            this.myBank = myBank;

        }
        public string BankName 
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }
        public Account[] myBank
        {
            get { return this.myBank;}
        }

        public void AddAccount(Account Account)
        {
            for (int value = 0; value < myBank.Length; value++)
            {

                if (myBank[value] == null)
                {
                    myBank[value] = Account;
                    myBank[value].AccountNumber = value;
                    break;
                }
                Console.WriteLine("Account Added");

                else Console.WriteLine("Cannot be Added");
            
            }
          public void DeleteAccount(int accountNumber)
            { 
                
            
            }
            public void Transaction()
            { 
            
            
            
            
            
            
            }


            public void PrintAccountDetails()
            {
                Console.WriteLine("Bank Name : " + this.bankName);

                for (int i = 0; i < myBank.Length; i++)
                {
                    myBank[i].ShowAccountInfo();
                }

            }




        }



    }
}
