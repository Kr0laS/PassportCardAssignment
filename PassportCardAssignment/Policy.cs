using PassportCardAssignment;
using System;

namespace PassportCardAssignment;


public class Policy
{

    public PolicyType Type { get; set; }

    #region General Policy Prop
    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
    #endregion

    #region Life Insurance
    public bool IsSmoker { get; set; }
    public decimal Amount { get; set; }
    #endregion

    #region Travel
    public string Country { get; set; }
    public int Days { get; set; }
    #endregion

    #region Health
    public string Gender { get; set; }
    public decimal Deductible { get; set; }
    #endregion
}


//I Wanted to arrange the policy type this way,
//but because i read the policy from a json file,
//i figured that could cause some problems when reading from the file
//since we cant know what is the expected type.
//public class Policy
//{
//    public PolicyType Type { get; set; }
//    public string FullName { get; set; }
//    public DateTime DateOfBirth { get; set; }
//}

//public class LifePolicy : Policy
//{
//    public bool IsSmoker { get; set; }
//    public decimal Amount { get; set; }
//}

//public class TravelPolicy : Policy
//{
//    public string Country { get; set; }
//    public int Days { get; set; }
//}

//public class HealthPolicy : Policy
//{
//    public string Gender { get; set; }
//    public decimal Deductible { get; set; }
//}
