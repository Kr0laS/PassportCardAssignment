using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportCardAssignment.PolicyRatingStrategy;

internal class PolicyRatingStrategyFactory
{
    public static IPolicyRatingStrategy CreatePolicyStrategy(Policy policy)
    {
        return policy.Type switch
        {
            PolicyType.Travel => new TravelPolicyRatingStrategy(),
            PolicyType.Life => new LifePolicyRatingStrategy(),
            PolicyType.Health => new HealthPolicyRatingStrategy(),
            _ => throw new NotSupportedException("Unsupported policy type"),
        };
    }
}
