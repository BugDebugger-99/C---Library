using System;
using Customer_area;
using Cx_manager;

class Program
{
    public static void Main()
    {
        CustomerManager customerManager = new CustomerManager();

        while (true)
        {
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Search Customer by Name");
            Console.WriteLine("3. Search Customer by ID");
            Console.WriteLine("4. Show All Customers");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter Unique ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Choose a Plan: ");
                Console.WriteLine("1. Basic Plan ($20)");
                Console.WriteLine("2. Premium Plan ($40)");
                Console.WriteLine("3. VIP Plan ($60)");
                Console.Write("Choose Plan: ");
                int planChoice = Convert.ToInt32(Console.ReadLine());
                string plan = planChoice switch
                {
                    1 => "Basic Plan",
                    2 => "Premium Plan",
                    3 => "VIP Plan",
                    _ => "No Plan"
                };

                Console.Write("Enter Amount Paid: $");
                double amountPaid = Convert.ToDouble(Console.ReadLine());

                customerManager.AddCustomer(new Customer(id, name, plan, amountPaid));
            }
            else if (choice == "2")
            {
                Console.Write("Enter Customer Name to search: ");
                string name = Console.ReadLine();
                customerManager.SearchCustomerByName(name);
            }
            else if (choice == "3")
            {
                Console.Write("Enter Customer ID to search: ");
                int id = Convert.ToInt32(Console.ReadLine());
                customerManager.SearchCustomerById(id);
            }
            else if (choice == "4")
            {
                customerManager.ShowAllCustomers();
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, try again.");
            }
        }
    }
}
