using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2 
{
    class CheckingAccount : Account
    {
        public CheckingAccount(int accountNumber, string accountName, double balance, Address address) : base(accountNumber, accountName, balance, address)
        {

        }
        public override void Withdraw(double ammount)
        {
            
        }
        public void ShowAccountInfo()
        {
            Console.WriteLine("ACCOUNT INFORMATION :\n" + "Account Number: " + this.accountNumber +
                "\nName: " + this.accountName + "\nBalance: " + this.balance + "\nAddress: " + address.getAddress());
        }
    }
}