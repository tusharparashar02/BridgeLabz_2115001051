using System;
using System.Collections.Generic;
using System.Linq;

class Policy
{
    public string PolicyNumber { get; set; }
    public string CoverageType { get; set; }
    public DateTime ExpiryDate { get; set; }

    public override bool Equals(object obj)
    {
        if (obj is Policy policy)
        {
            return PolicyNumber == policy.PolicyNumber;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return PolicyNumber.GetHashCode();
    }
}

class InsurancePolicyManagement
{
    private HashSet<Policy> uniquePolicies = new HashSet<Policy>();
    private LinkedList<Policy> orderedPolicies = new LinkedList<Policy>();
    private SortedSet<Policy> sortedPolicies = new SortedSet<Policy>(Comparer<Policy>.Create((a, b) => a.ExpiryDate.CompareTo(b.ExpiryDate)));

    public void AddPolicy(Policy policy)
    {
        if (uniquePolicies.Add(policy))
        {
            orderedPolicies.AddLast(policy);
            sortedPolicies.Add(policy);
        }
    }

    public List<Policy> GetExpiringSoon()
    {
        DateTime now = DateTime.Now;
        return sortedPolicies.Where(p => (p.ExpiryDate - now).TotalDays <= 30).ToList();
    }

    static void Main()
    {
        InsurancePolicyManagement system = new InsurancePolicyManagement();
        system.AddPolicy(new Policy { PolicyNumber = "P111", CoverageType = "Health", ExpiryDate = DateTime.Now.AddDays(10) });
        system.AddPolicy(new Policy { PolicyNumber = "P112", CoverageType = "Auto", ExpiryDate = DateTime.Now.AddDays(40) });

        List<Policy> expiringSoon = system.GetExpiringSoon();
        Console.WriteLine("Expiring Soon Policies:");
        foreach (Policy policy in expiringSoon)
        {
            Console.WriteLine(policy.PolicyNumber + " - " + policy.CoverageType);
        }
    }
}
