using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Management_System.Entity
{

    public class Clients
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ContactInfo { get; set; }
        public int PolicyId { get; set; }

        public Clients() { }

        public Clients(int clientId, string clientName, string contactInfo, int policyId)
        {
            ClientId = clientId;
            ClientName = clientName;
            ContactInfo = contactInfo;
            PolicyId = policyId;
        }

        public override string ToString()
        {
            return $"Client{{ClientId={ClientId}, ClientName={ClientName}, ContactInfo={ContactInfo}, PolicyId={PolicyId}}}";

        }
    }
}
