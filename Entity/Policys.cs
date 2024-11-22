using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Management_System.Entity
{
    public class Policys
    {
        public int PolicyId { get; set; }
        public string PolicyName { get; set; }
        public string PolicyDetails { get; set; }

        public Policys() { }

        public Policys(int policyId, string policyName, string policyDetails)
        {
            PolicyId = policyId;
            PolicyName = policyName;
            PolicyDetails = policyDetails;

        }
        public override string ToString()
        {
            return $"Policy{{PolicyId={PolicyId}, PolicyName={PolicyName}, PolicyDetails={PolicyDetails}}}";
        }
    }
}
