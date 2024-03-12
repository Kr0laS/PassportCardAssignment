using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PassportCardAssignment.PolicyRatingStrategy;

public class LifePolicyRatingStrategy : IPolicyRatingStrategy
{
    public decimal RatePolicy(Policy policy)
    {
        Console.WriteLine("Rating LIFE policy...");
        Console.WriteLine("Validating policy.");

        if (policy.DateOfBirth == DateTime.MinValue)
        {
            throw new ArgumentException("Life policy must include Date of Birth.");
        }

        if (policy.DateOfBirth < DateTime.Today.AddYears(-100))
        {
            throw new ArgumentException("Max eligible age for coverage is 100 years.");
        }

        if (policy.Amount == 0)
        {
            throw new ArgumentException("Life policy must include an Amount.");
        }

        int age = DateTime.Today.Year - policy.DateOfBirth.Year;
        
        if (HasBirthdayOccured(policy.DateOfBirth))
        {
            age--;
        }

        decimal baseRate = policy.Amount * age / 200;

        if (policy.IsSmoker)
        {
            return baseRate * 2;
        }

        return baseRate;
    }

    private bool HasBirthdayOccured(DateTime DateOfBirth) => 
        DateOfBirth.Month == DateTime.Today.Month &&
        DateTime.Today.Day < DateOfBirth.Day ||
        DateTime.Today.Month < DateOfBirth.Month;
}
