using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_1

{
        static void Main(string[] args)
        {
            Console.Write("Enter Your Bank Name : ");
            string bankName = Console.ReadLine();
            Console.Write("How many account you Want to insert ? :");
            int size = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Select the following option : ");
                Console.Write("1. Add Account\n2. Delete Account\n3. Transaction\n4. Exit\n\nEnter : ");
                int x = Convert.ToInt32(Console.ReadLine());

                if (x == 1)
                {
                    Console.Write("Enter Account : \nName : ");
                    string accountName = Console.ReadLine();
                    Console.Write("Balance : ");
                    double balance = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Address :\nRoad No. : ");
                    string roadNo = Console.ReadLine();
                    Console.Write("House No. : ");
                    string houseNo = Console.ReadLine();
                    Console.Write("City : ");
                    string city = Console.ReadLine();
                    Console.Write("Country : ");
                    string country = Console.ReadLine();


                    b1.AddAccount(new Account(id, accountName, balance, new Address(roadNo, houseNo, city, country)));


                }
             