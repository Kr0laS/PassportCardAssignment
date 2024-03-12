using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportCardAssignment.PolicyRatingStrategy;

public class HealthPolicyRatingStrategy : IPolicyRatingStrategy
{
    public decimal RatePolicy(Policy policy)
    {
        Console.WriteLine("Rating HEALTH policy...");
        Console.WriteLine("Validating policy.");


        if (string.IsNullOrEmpty(policy.Gender))
        {
            throw new ArgumentException("Unknown Policy Gender");
        }

        if (policy.Gender == "Male")
        {
            if (policy.Deductible < 500) return 1000m;

            return 900m;
        }

        if (policy.Deductible < 800) return 1100m;

        return 1000m;
    }
}
