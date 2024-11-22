using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Management_System.Entity
{

    public class Payments
    {
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public int ClientId { get; set; }

        public Payments() { }

        public Payments(int paymentId, DateTime paymentDate, decimal paymentAmount, int clientId)
        {
            PaymentId = paymentId;
            PaymentDate = paymentDate;
            PaymentAmount = paymentAmount;
            ClientId = clientId;
        }
        public override string ToString()
        {
            return $"Payment{{PaymentId={PaymentId}, PaymentDate={PaymentDate}, PaymentAmount={PaymentAmount}, ClientId={ClientId}}}";
        }
    }
}
