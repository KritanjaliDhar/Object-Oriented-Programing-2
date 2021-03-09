using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2 
{
    class SavingsAccount : Account
    {
        public SavingsAccount(int accountNumber, string accountName, double balance, Address address) : base(accountNumber, accountName, balance, address)
        {

        }
        public void Withdraw(double ammount)
        {
            
                if (balance < ammount)
                {
                    Console.WriteLine("INSUFFICIENT BALANCE");
                }
                else
                {
                    balance -= ammount;
                }
         }
            else
            {
                Console.WriteLine("SOMETHING WRONG!");
            }
        }
        public override void ShowAccountInfo()
        {
            Console.WriteLine("ACCOUNT INFORMATION :\n" + "Account Number: " + this.accountNumber +
                "\nName: " + this.accountName + "\nBalance: " + this.balance + "\nAddress: " + address.getAddress());
        }
    }
}