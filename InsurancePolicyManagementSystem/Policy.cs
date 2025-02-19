using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurancePolicyManagementSystem
{
    internal class Policy
    {
        public string PolicyNumber { get; set; }
        public string HolderName { get; set; }
        public string CoverageType { get; set; }
        public DateTime ExpiryDate { get; set; }

        public Policy(string policyNumber, string holderName, string coverageType, DateTime expiryDate)
        {
            PolicyNumber = policyNumber;
            HolderName = holderName;
            CoverageType = coverageType;
            ExpiryDate = expiryDate;
        }

        public int CompareTo(Policy other)
        {
            return ExpiryDate.CompareTo(other.ExpiryDate);
        }

        public override bool Equals(object obj)
        {
            return obj is Policy policy && PolicyNumber == policy.PolicyNumber;
        }

        public override int GetHashCode()
        {
            return PolicyNumber.GetHashCode();
        }

        public override string ToString()
        {
            return $"Policy: {PolicyNumber}, Holder: {HolderName}, Type: {CoverageType}, Expiry: {ExpiryDate.ToShortDateString()}";
        }
    }
}
