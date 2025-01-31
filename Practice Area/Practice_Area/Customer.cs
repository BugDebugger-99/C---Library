namespace Customer_area
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Plan { get; set; }
        public double AmountPaid { get; set; }
        public double PendingAmount { get; set; }
        public string PaymentStatus { get; set; }
        public string ServiceStatus { get; set; }

        public Customer(int id, string name, string plan, double amountPaid)
        {
            this.Id = id;
            this.Name = name;
            this.Plan = plan;
            this.AmountPaid = amountPaid;
            this.PendingAmount = CalculatePendingAmount(amountPaid, plan); 
            this.PaymentStatus = CalculatePaymentStatus(amountPaid, plan); 
            this.ServiceStatus = CalculateServiceStatus(amountPaid, plan); 
        }

        private string AssignPlan(double amountPaid)
        {
            if (amountPaid >= 60) return "VIP Plan";
            if (amountPaid >= 40) return "Premium Plan";
            if (amountPaid >= 20) return "Basic Plan";
            return "No Plan"; 
        }

       
        private double CalculatePendingAmount(double amountPaid, string plan)
        {
            double requiredAmount = 0;

            if (plan == "VIP Plan") requiredAmount = 60;
            else if (plan == "Premium Plan") requiredAmount = 40;
            else if (plan == "Basic Plan") requiredAmount = 20;

            
            if (amountPaid < requiredAmount)
            {
                return requiredAmount - amountPaid;
            }
            else
            {
                return 0; 
            }
        }

        
        private string CalculatePaymentStatus(double amountPaid, string plan)
        {
            double requiredAmount = 0;

            if (plan == "VIP Plan") requiredAmount = 60;
            else if (plan == "Premium Plan") requiredAmount = 40;
            else if (plan == "Basic Plan") requiredAmount = 20;

            return amountPaid >= requiredAmount ? "Paid" : "Unpaid";
        }

        private string CalculateServiceStatus(double amountPaid, string plan)
        {
            double requiredAmount = 0;

            if (plan == "VIP Plan") requiredAmount = 60;
            else if (plan == "Premium Plan") requiredAmount = 40;
            else if (plan == "Basic Plan") requiredAmount = 20;

            return amountPaid >= requiredAmount ? "Active" : "Not Active";
        }

        public void CustomerDetails()
        {
            Console.WriteLine($"Id: {this.Id}, Name: {this.Name}, Plan: {this.Plan}, Amount Paid: ${this.AmountPaid}");
            
            if (this.PendingAmount > 0)
            {
                Console.WriteLine($"Pending amount: ${this.PendingAmount}");
            }

            Console.WriteLine($"Payment Status: {this.PaymentStatus}");
            Console.WriteLine($"Service Status: {this.ServiceStatus}");
        }
    }
}
