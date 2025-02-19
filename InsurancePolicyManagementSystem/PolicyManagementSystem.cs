using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurancePolicyManagementSystem
{
    internal class PolicyManagementSystem
    {
        private HashSet<Policy> policySet = new HashSet<Policy>();
        private LinkedList<Policy> policyOrderList = new LinkedList<Policy>();
        private SortedSet<Policy> sortedPolicies = new SortedSet<Policy>();

        public void AddPolicy(Policy policy)
        {
            if (policySet.Add(policy)) // Ensures uniqueness
            {
                policyOrderList.AddLast(policy); // Maintains insertion order
                sortedPolicies.Add(policy); // Maintains sorted order
            }
        }

        public List<Policy> GetAllPolicies()
        {
            return policyOrderList.ToList();
        }

        public List<Policy> GetExpiringSoon()
        {
            DateTime today = DateTime.Today;
            DateTime threshold = today.AddDays(30);
            return sortedPolicies.Where(p => p.ExpiryDate <= threshold).ToList();
        }

        public List<Policy> GetPoliciesByCoverage(string coverageType)
        {
            return policySet.Where(p => p.CoverageType.Equals(coverageType, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Policy> GetDuplicatePolicies()
        {
            var policyCount = new Dictionary<string, int>();
            var duplicates = new List<Policy>();

            foreach (var policy in policySet)
            {
                if (policyCount.ContainsKey(policy.PolicyNumber))
                    policyCount[policy.PolicyNumber]++;
                else
                    policyCount[policy.PolicyNumber] = 1;
            }

            foreach (var policy in policySet)
            {
                if (policyCount[policy.PolicyNumber] > 1)
                    duplicates.Add(policy);
            }

            return duplicates;
        }
    }
}
