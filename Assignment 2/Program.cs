using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2 
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("TEST BANK");

            Console.WriteLine("\nPLEASE SELECT AN OPTION ");
            Console.WriteLine("\nSelect Required Option");
            Console.Write("1. Open Account(open)\n2. Make Transaction(account)\n3. Exit(quit)\n\nEnter : ");
            string x = System.Console.ReadLine();

            switch (x)
            {
                case "open":
                    Console.WriteLine("\n______Select Account Type_______ ");
                    Console.Write("1. Savings Account(savings)\n2. Checkings Account(checkings)\n3. Exit(quit)\n\nEnter : ");
                    string y = System.Console.ReadLine();
                    break;

                    switch (y)
                    {
                        case "savings" && "checkings":
                            {
                                

                           

                                
                            }
                       
                    }

                