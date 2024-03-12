using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PassportCardAssignment.PolicyRatingStrategy;

namespace PassportCardAssignment;

/// <summary>
/// The RatingEngine reads the policy application details from a file and produces a numeric 
/// rating value based on the details.
/// </summary>
public class RatingEngine
{
    public decimal Rating { get; set; }



    public void Rate()
    {
        // log start rating
        Console.WriteLine("Starting rate.");

        Console.WriteLine("Loading policy.");

        var policy = PolicyRepository.GetPolicy();

        var strategy = PolicyRatingStrategyFactory.CreatePolicyStrategy(policy);

        Rating = strategy.RatePolicy(policy);

        Console.WriteLine("Rating completed.");
    }
}
