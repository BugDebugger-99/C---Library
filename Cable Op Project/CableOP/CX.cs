using CxManager;
using BillingPlan;
namespace CX
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Plan { get; set; }

        public Billing Billing { get; set; }
        public Customer(string name, string plan, double amountPaid)
        {

            this.Name = name;
            this.Plan = plan;
            this.Billing = new Billing(plan, amountPaid);

        }

    }

}