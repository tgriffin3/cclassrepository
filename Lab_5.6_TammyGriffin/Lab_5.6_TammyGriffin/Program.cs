using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_5._6_TammyGriffin
{
    class Program
    {
        public struct Customer
        {
            public string FirstName;
            public string LastName;
            public int age;
            public bool memberStatus;

        }
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();
            

            customer1.FirstName = "Jack";
            customer1.LastName = "Spratt";
            customer1.age = 20;
            customer1.memberStatus = false;

            customer2.FirstName = "Michelle";
            customer2.LastName = "Black";
            customer2.age = 37;
            customer2.memberStatus = false;

            customer3.FirstName = "Barak";
            customer3.LastName = "Jamisen";
            customer3.age = 50;
            customer3.memberStatus = true;

            Customer[] Customers = { customer1, customer2, customer3 };
            for (int i = 0; i < Customers.Length; i++)
            {
                if (Customers[i].age <= 21)
                {
                    Console.WriteLine(Customers[i].FirstName + " " + Customers[i].LastName + " UNDERAGE unable to order");
                }

                else{ 
                Console.WriteLine(Customers[i].FirstName + " " + Customers[i].LastName + " show order form");
                }


                if (Customers[i].memberStatus == true)
                {
                    Console.WriteLine(Customers[i].FirstName + " " + Customers[i].LastName + " Premium Member discount applies");
                }
                else
                {
                    Console.WriteLine(Customers[i].FirstName + " " + Customers[i].LastName + " not a premium member");
                }

            }
        }
    }
}
