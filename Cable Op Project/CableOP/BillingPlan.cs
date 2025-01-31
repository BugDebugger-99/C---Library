using System.Collections;
using CX;
using CxManager;
namespace BillingPlan
{
    public class Billing
    {
        public string Plan { get; set; }
        public double AmountPaid { get; set; }

        public Billing(string plan, double amountPaid)
        {
            this.Plan = plan;
            this.AmountPaid += amountPaid;
        }


        public string GetPaymentStatus(out double pendingAmount)
        {
            double planCost = 0;
            pendingAmount = 0;

            if (Plan == "Basic")
                planCost = 19.99;
            else if (Plan == "Premium")
                planCost = 25.99;
            else if (Plan == "VIP")
                planCost = 30.99;


            if (AmountPaid >= planCost)
                return "Paid";
            else
                pendingAmount = planCost - AmountPaid;
            return "Unpaid";

        }

        public void UpdatePlan(string newPlan)
        {
            this.Plan = newPlan;
        }

        public void UpdatePayment(double newAmountPaid)
        {
            this.AmountPaid += newAmountPaid;
        }

    }

}

