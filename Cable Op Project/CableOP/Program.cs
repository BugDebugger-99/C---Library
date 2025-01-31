using System;
using CX;
using CxManager;
using BillingPlan;

class Program
{
    public static void Main()
    {
        CustomerManager customerManager = new CustomerManager();

        Console.WriteLine("=======================================");
        Console.WriteLine("  Welcome to Cable Operating System");
        Console.WriteLine("=======================================\n");

        while (true)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("  Main Menu - Select an Option Below");
            Console.WriteLine("=======================================");
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Search Customer by Name");
            Console.WriteLine("3. Search Customer by ID");
            Console.WriteLine("4. Remove Customer");
            Console.WriteLine("5. Show All Customers");
            Console.WriteLine("6. Update Customer's Name");
            Console.WriteLine("7. Update Customer's Plan");
            Console.WriteLine("8. Update Customer's Payment Status");
            Console.WriteLine("9. Exit");
            Console.WriteLine("=======================================\n");



            Console.Write("Choose an option: ");
            string choiceInput = Console.ReadLine();

            // Validate if the input is a number
            if (!int.TryParse(choiceInput, out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
                continue;
            }

            switch (choice)
            {
                //  Add a new customer
                case 1:
                    
                    Console.Write("\n--- ADD New Customer ---\n");
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();

                    // Validate  the name 
                    if (string.IsNullOrWhiteSpace(name) || int.TryParse(name, out _))
                    {
                        Console.WriteLine("Invalid name. Please enter a valid name.");
                        continue;
                    }

                    string plan = null;
                    bool validPlanChoice = false;

                    // valid plan 
                    while (!validPlanChoice)
                    {
                        Console.WriteLine("\nAvailable Plans:");
                        Console.WriteLine("1. Basic ($19.99)");
                        Console.WriteLine("2. Premium ($25.99)");
                        Console.WriteLine("3. VIP ($30.99)");
                        Console.Write("Choose Plan: ");
                        string planChoiceInput = Console.ReadLine();

                        // Validate the plan 
                        if (!int.TryParse(planChoiceInput, out int planChoice))
                        {
                            Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
                            continue;
                        }

                        // Assign the plan 
                        switch (planChoice)
                        {
                            case 1:
                                plan = "Basic";
                                validPlanChoice = true;
                                break;
                            case 2:
                                plan = "Premium";
                                validPlanChoice = true;
                                break;
                            case 3:
                                plan = "VIP";
                                validPlanChoice = true;
                                break;
                            default:
                                Console.WriteLine("Invalid choice! Please select 1, 2, or 3.");
                                break;
                        }
                    }

                    // amount paid
                    Console.Write("Enter Amount: $");
                    string amountInput = Console.ReadLine();
                    if (!double.TryParse(amountInput, out double amountPaid) || amountPaid <= 0)
                    {
                        Console.WriteLine("Invalid amount. Please enter a positive number.");
                        continue;
                    }

                    // Add the customer
                    Customer customer = new Customer(name, plan, amountPaid);
                    customerManager.AddCustomer(customer);
                    continue;

                //  Search for a customer by name
                case 2:
                    
                    Console.WriteLine("\n--- Search Customer by Name ---\n");
                    Console.Write("Enter Customer Name: ");
                    string cxNameToSearch = Console.ReadLine().ToLower();
                    customerManager.SearchCustomerByName(cxNameToSearch);
                    Console.WriteLine("\nSearch complete.\n");
                    continue;

                //  Search for a customer by ID
                case 3:
                 
                    Console.WriteLine("\n--- Search Customer by ID ---\n");
                    Console.Write("Enter Customer ID: ");
                    string idInput = Console.ReadLine();
                    if (!int.TryParse(idInput, out int cxIdToSearch))
                    {
                        Console.WriteLine("Invalid ID. Please enter a number.");
                        continue;
                    }
                    customerManager.SearchCustomerById(cxIdToSearch);
                    Console.WriteLine("\nSearch complete.\n");
                    continue;

                //  Remove a customer
                case 4:
                   
                    Console.WriteLine("\n--- Remove Customer ---\n");
                    Console.Write("Enter Customer Name: ");
                    string cxNameToRemove = Console.ReadLine().ToLower();
                    customerManager.RemoveCustomer(cxNameToRemove);
                    continue;

                //  Show all customers
                case 5:
                    Console.WriteLine("\n--- All Customers ---\n");
                    customerManager.ShowCustomers();
                    Console.WriteLine("\nEnd of customer list.\n");
                    continue;

                //  Update a customer's name
                case 6:
                  
                    Console.WriteLine("\n--- Update Customer Name ---\n");
                    Console.Write("Enter Current Customer Name: ");
                    string oldName = Console.ReadLine().ToLower();
                    Console.Write("Enter New Customer Name: ");
                    string newName = Console.ReadLine();

                    // Validate the new name
                    if (string.IsNullOrWhiteSpace(newName) || int.TryParse(newName, out _))
                    {
                        Console.WriteLine("Invalid name. Please enter a valid name.");
                        continue;
                    }
                    customerManager.UpdateCustomerName(oldName, newName);
                    continue;

                //  Update a customer's plan
                case 7:
                   
                    Console.WriteLine("\n--- Update Customer Plan ---\n");
                    string newPlan = null;
                    bool validNewPlanChoice = false;

                    Console.Write("Enter Customer Name: ");
                    string customerName = Console.ReadLine();
                    while (!validNewPlanChoice)
                    {
                        Console.WriteLine("\nAvailable Plans: ");
                        Console.WriteLine("1. Basic ($19.99)");
                        Console.WriteLine("2. Premium ($25.99)");
                        Console.WriteLine("3. VIP ($30.99)");
                        Console.Write("Choose New Plan: ");

                        string newPlanChoiceInput = Console.ReadLine();
                        if (!int.TryParse(newPlanChoiceInput, out int newPlanChoice))
                        {
                            Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
                            continue;
                        }

                        // Assign the new plan
                        switch (newPlanChoice)
                        {
                            case 1:
                                newPlan = "Basic";
                                validNewPlanChoice = true;
                                break;
                            case 2:
                                newPlan = "Premium";
                                validNewPlanChoice = true;
                                break;
                            case 3:
                                newPlan = "VIP";
                                validNewPlanChoice = true;
                                break;
                            default:
                                Console.WriteLine("Invalid plan choice!");
                                continue;
                        }
                    }
                    customerManager.UpdateCustomerPlan(customerName, newPlan);
                    continue;

                //  Update a customer's payment status
                case 8:
                
                    Console.WriteLine("\n--- Update Customer Payment Status ---\n");
                    Console.Write("Enter Customer Name: ");
                    string paymentCustomerName = Console.ReadLine();
                    Console.Write("Enter New Payment Amount: $");
                    string newPaymentInput = Console.ReadLine();
                    if (!double.TryParse(newPaymentInput, out double newPaymentAmount) || newPaymentAmount <= 0)
                    {
                        Console.WriteLine("Invalid amount. Please enter a positive number.");
                        continue;
                    }
                    customerManager.UpdateCustomerPaymentStatus(paymentCustomerName, newPaymentAmount);
                    continue;

                //  Exit the program
                case 9:
                    Console.WriteLine("\nThank you for using Cable Operator. Goodbye!\n");
                    return;


                default:
                    Console.WriteLine("Invalid Choice! Please select a number between 1 and 9.");
                    continue;
                    // Samir Khan
            }
        }
    }
}
