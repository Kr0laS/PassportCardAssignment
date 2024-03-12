using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportCardAssignment.PolicyRatingStrategy;

public class TravelPolicyRatingStrategy : IPolicyRatingStrategy
{
    public decimal RatePolicy(Policy policy)
    {
        Console.WriteLine("Rating TRAVEL policy...");
        Console.WriteLine("Validating policy.");

        if (policy.Days <= 0)
        {
            throw new ArgumentException("Travel policy must specify Days.");
        }

        if (policy.Days > 180)
        {
            throw new ArgumentException("Travel policy cannot be more then 180 Days.");
        }

        if (string.IsNullOrEmpty(policy.Country))
        {
            throw new ArgumentException("Travel policy must specify country.");
        }

        decimal rating = policy.Days * 2.5m;

        if (policy.Country == "Italy")
            return rating *= 3;

        return rating;
    }
}
