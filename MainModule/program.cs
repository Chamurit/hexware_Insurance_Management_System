using Insurance_Management_System.Entity;
using Insurance_Management_System.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Management_System.MainModule
{
    public class MainModule
    {
        public static void Main(string[] args)
        {

            // Initialize the service
            IPolicyService policyService = new InsuranceServiceImpl();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nInsurance Management System Menu:");
                Console.WriteLine("1. Create Policy");
                Console.WriteLine("2. Get Policy");
                Console.WriteLine("3. Get All Policies");
                Console.WriteLine("4. Update Policy");
                Console.WriteLine("5. Delete Policy");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            CreatePolicy(policyService);
                            break;
                        case 2:
                            GetPolicy(policyService);
                            break;
                        case 3:
                            GetAllPolicies(policyService);
                            break;
                        case 4:
                            UpdatePolicy(policyService);
                            break;
                        case 5:
                            DeletePolicy(policyService);
                            break;
                        case 6:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        private static void CreatePolicy(IPolicyService policyService)
        {
            Console.Write("Enter Policy ID: ");
            int policyId = int.Parse(Console.ReadLine());
            Console.Write("Enter Policy Name: ");
            string policyName = Console.ReadLine();
            Console.Write("Enter PolicyDetails: ");
            string PolicyDetails = Console.ReadLine();

            Policys policy = new Policys { PolicyId = policyId, PolicyName = policyName, PolicyDetails = PolicyDetails };
            bool isCreated = policyService.CreatePolicy(policy);
            Console.WriteLine("Policy Created: " + isCreated);
        }

        private static void GetPolicy(IPolicyService policyService)
        {
            Console.Write("Enter Policy ID: ");
            int policyId = int.Parse(Console.ReadLine());

            Policys policy = policyService.GetPolicy(policyId);
            if (policy != null)
            {
                Console.WriteLine("Policy Details: " + policy);
            }
            else
            {
                Console.WriteLine("Policy not found.");
            }
        }

        private static void GetAllPolicies(IPolicyService policyService)
        {
            var allPolicies = policyService.GetAllPolicies();
            Console.WriteLine("All Policies:");
            foreach (var policy in allPolicies)
            {
                Console.WriteLine(policy);
            }
        }
        private static void DeletePolicy(IPolicyService policyService)
        {
            Console.Write("Enter Policy ID to Delete: ");

            int policyId = int.Parse(Console.ReadLine());
            bool isDeleted = policyService.DeletePolicy(policyId);
            Console.WriteLine("Policy Deleted: " + isDeleted);
        }

        private static void UpdatePolicy(IPolicyService policyService)
        {
            Console.Write("Enter Policy ID to Update: ");
            int policyId = int.Parse(Console.ReadLine());
            Console.Write("Enter Updated Policy Name: ");
            string policyName = Console.ReadLine();

            Console.Write("Enter Updated PolicyDetails: ");
            string PolicyDetails = Console.ReadLine();
            string? policyDetails = null;
            Policys policy = new Policys
            {
                PolicyId = policyId,
                PolicyName = policyName,
                PolicyDetails = policyDetails
            };
            bool isUpdated = policyService.UpdatePolicy(policy);
            Console.WriteLine("Policy Updated: " + isUpdated);
        }
    }

}


