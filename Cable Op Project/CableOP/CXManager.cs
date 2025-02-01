using CX;
using BillingPlan;

namespace CxManager
{
    public class CustomerManager
    {
        public List<Customer> customers = new List<Customer>();
        public static int idCounter = 1;

        // Adding Customer
        public void AddCustomer(Customer customer)
        {
            customer.Id = idCounter++;
            customers.Add(customer);
            Console.Clear();
            Console.WriteLine($"Cx {customer.Name} added!");
        }

        // Removing Customer
        public void RemoveCustomer(string name)
        {

            if (customers.Count == 0)
            {
                Console.WriteLine("No Customer Available...");
            }

            foreach (var customer in customers)
            {
                if (customer.Name.ToLower() == name.ToLower())
                {
                    Console.WriteLine("Customer Found! Removing it...");
                    customers.Remove(customer);

                    Console.WriteLine($"Cx {customer.Name} removed!");
                    break;
                }
            }
        }


        // Search Customer -- By Name
        public void SearchCustomerByName(string name)
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No Customer Available...");
            }

            bool found = false;
            foreach (var customer in customers)
            {

                if (customer.Name.ToLower() == name.ToLower())
                {

                    string paymentStatus = customer.Billing.GetPaymentStatus(out double pendingAmount);

                    Console.WriteLine("Customer Found! Here's the details...");
                    Console.WriteLine($"Id:{customer.Id}, Name: {customer.Name}, Plan: {customer.Plan}, Payment Status: {paymentStatus}, Amount Paid: {customer.Billing.AmountPaid:C}");

                    if (paymentStatus == "Unpaid")
                    {
                        Console.WriteLine($"{customer.Name}'s Pending Amount: ${pendingAmount:F2}");
                    }

                    found = true;
                    break;

                }

            }

            if (!found)
            {
                Console.WriteLine("Customer not found...");
            }

        }

        // Search Customer -- By Id
        public void SearchCustomerById(int id)
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No Customer Available...");
            }

            bool found = false;
            foreach (var customer in customers)
            {
                if (customer.Id == id)
                {
                    string paymentStatus = customer.Billing.GetPaymentStatus(out double pendingAmount);

                    Console.WriteLine("Customer Found! Here's the details...");
                    Console.WriteLine($"Id:{customer.Id}, Name: {customer.Name}, Plan: {customer.Plan}, Payment Status: {paymentStatus}, Amount Paid: {customer.Billing.AmountPaid:C}");

                    if (paymentStatus == "Unpaid")
                    {
                        Console.WriteLine($"{customer.Name}'s Pending Amount: ${pendingAmount:F2}");
                    }

                    found = true;
                    break;
                }

            }

            if (!found)
            {
                Console.WriteLine("Customer not found...");
            }

        }

        // Show Customers
        public void ShowCustomers()
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No Customer Available...");
            }

            foreach (var customer in customers)
            {
                string paymentStatus = customer.Billing.GetPaymentStatus(out double pendingAmount);

                Console.WriteLine($"Id: {customer.Id}, Name: {customer.Name},  Plan: {customer.Plan}, Status: {paymentStatus}, Amount Paid: {customer.Billing.AmountPaid:C}");
                if (paymentStatus == "Unpaid")
                {
                    Console.WriteLine($"{customer.Name}'s Pending Amount: ${pendingAmount:F2}");
                }
            }
        }

        // Updating Customer's Name
        public void UpdateCustomerName(string oldName, string newName)
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No Customer Available...");
            }

            bool found = false;
            foreach (var customer in customers)
            {
                if (customer.Name.ToLower() == oldName.ToLower())
                {
                    customer.Name = newName;
                    Console.WriteLine($"Customer name updated to {newName}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Customer not found...");
            }
        }

        public void UpdateCustomerPlan(string name, string newPlan)
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No Customer Available...");
                return;
            }

            bool found = false;
            foreach (var customer in customers)
            {
                if (customer.Name.ToLower() == name.ToLower())
                {

                    double oldPlanCost = 0;
                    double newPlanCost = 0;

                    if (customer.Plan == "VIP")
                        oldPlanCost = 30.99;
                    else if (customer.Plan == "Premium")
                        oldPlanCost = 25.99;
                    else if (customer.Plan == "Basic")
                        oldPlanCost = 19.99;

                    if (newPlan == "VIP")
                        newPlanCost = 30.99;
                    else if (newPlan == "Premium")
                        newPlanCost = 25.99;
                    else if (newPlan == "Basic")
                        newPlanCost = 19.99;

                    double refundAmount = 0;
                    if (newPlanCost < oldPlanCost)
                    {
                        refundAmount = customer.Billing.AmountPaid - newPlanCost;
                        customer.Billing.AmountPaid -= refundAmount;
                    }
                    else if (newPlanCost > oldPlanCost)
                    {
                        Console.WriteLine($"New plan ({newPlan}) costs more than the current plan.");
                        Console.Write("Enter additional amount to pay: $");
                        double extraAmount = Convert.ToDouble(Console.ReadLine());
                        customer.Billing.AmountPaid += extraAmount;
                    }

                    customer.Plan = newPlan;
                    customer.Billing.UpdatePlan(newPlan);

                    Console.WriteLine($"Customer's Plan updated to {newPlan}");
                    if (refundAmount > 0)
                    {
                        Console.WriteLine($"Refund Amount: ${refundAmount:F2}");
                    }

                    found = true;
                    break;
                }
            }
        }

        public void UpdateCustomerPaymentStatus(string customerName, double newAmountPaid)
        {

            if (customers.Count == 0)
            {
                Console.WriteLine("No Customer Available...");
            }

            bool found = false;
            foreach (var customer in customers)
            {

                if (customer.Name.ToLower() == customerName.ToLower())
                {
                    customer.Billing.UpdatePayment(newAmountPaid);
                    string paymentStatus = customer.Billing.GetPaymentStatus(out double pendingAmount);

                    Console.WriteLine($"Payment updated to {newAmountPaid:C}. Payment Status: {paymentStatus}");
                    if (paymentStatus == "Unpaid")
                    {
                        Console.WriteLine($"Pending Amount: ${pendingAmount:F2}");
                    }

                    found = true;
                    break;

                }

            }

        }

    }
}








