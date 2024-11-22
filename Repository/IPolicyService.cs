using Insurance_Management_System.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Management_System.Repository
{
    public interface IPolicyService
    {
        bool CreatePolicy(Policys policy);
        Policys GetPolicy(int policyId);
        IEnumerable<Policys> GetAllPolicies();
        bool UpdatePolicy(Policys policy);
        bool DeletePolicy(int policyId);
    }
}
