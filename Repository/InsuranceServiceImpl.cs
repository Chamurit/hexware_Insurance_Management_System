using Insurance_Management_System.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Management_System.Repository
{
    public class InsuranceServiceImpl : IPolicyService
    {
        private readonly string _connectionString;

        public InsuranceServiceImpl(string connectionString)
        {
            _connectionString = connectionString;
        }

        public InsuranceServiceImpl()
        {
        }

        public bool CreatePolicy(Policys policy)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Policies (policyName, policyDetails) VALUES (@policyName, @policyDetails)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@policyName", policy.PolicyName);
                cmd.Parameters.AddWithValue("@policyDetails", policy.PolicyDetails);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public Policys GetPolicy(int policyId)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Policies WHERE policyId = @policyId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@policyId", policyId);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Policys
                        {
                            PolicyId = (int)reader["policyId"],
                            PolicyName = reader["policyName"].ToString(),
                            PolicyDetails = reader["policyDetails"].ToString()
                        };
                    }
                }
            }
            return null;
        }

        public IEnumerable<Policys> GetAllPolicies()
        {
            var policies = new List<Policys>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Policies";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        policies.Add(new Policys
                        {
                            PolicyId = (int)reader["policyId"],
                            PolicyName = reader["policyName"].ToString(),
                            PolicyDetails = reader["policyDetails"].ToString()
                        });
                    }
                }
            }
            return policies;
        }

        public bool UpdatePolicy(Policys policy)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Policies SET policyName = @policyName, policyDetails = @policyDetails WHERE policyId = @policyId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@policyName", policy.PolicyName);
                cmd.Parameters.AddWithValue("@policyDetails", policy.PolicyDetails);
                cmd.Parameters.AddWithValue("@policyId", policy.PolicyId);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeletePolicy(int policyId)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Policies WHERE policyId = @policyId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@policyId", policyId);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
