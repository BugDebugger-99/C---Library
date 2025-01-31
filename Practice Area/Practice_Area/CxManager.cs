using Customer_area;

namespace Cx_manager
{
    public class CustomerManager
    {
        private List<Customer> customers = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine($"Customer {customer.Name} added.");
        }

        public void SearchCustomerByName(string name)
        {
            foreach (var customer in customers)
            {
                if (customer.Name.ToLower() == name.ToLower())
                {
                    customer.CustomerDetails();
                    return;
                }
            }
            Console.WriteLine("Customer not found.");
        }

        public void SearchCustomerById(int id)
        {
            foreach (var customer in customers)
            {
                if (customer.Id == id)
                {
                    customer.CustomerDetails();
                    return;
                }
            }
            Console.WriteLine("Customer not found.");
        }

        public void ShowAllCustomers()
        {
            foreach (var customer in customers)
            {
                customer.CustomerDetails();
            }
        }
    }
}
