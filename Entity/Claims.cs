using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Management_System.Entity
{
    public class Claims
    {
        public int ClaimId { get; set; }
        public string ClaimNumber { get; set; }
        public DateTime DateFiled { get; set; }
        public decimal ClaimAmount { get; set; }
        public string Status { get; set; }
        public int PolicyId { get; set; }
        public int ClientId { get; set; }

        public Claims() { }

        public Claims(int claimId, string claimNumber, DateTime dateFiled, decimal claimAmount, string status, int policyId, int clientId)
        {
            ClaimId = claimId;
            ClaimNumber = claimNumber;
            DateFiled = dateFiled;
            ClaimAmount = claimAmount;
            Status = status;
            PolicyId = policyId;
            ClientId = clientId;
        }
        public override string ToString()
        {
            return $"Claim{{ClaimId={ClaimId}, ClaimNumber={ClaimNumber}, DateFiled={DateFiled}, ClaimAmount={ClaimAmount}, Status={Status}, PolicyId={PolicyId}, ClientId={ClientId}}}";
        }
    }
}
