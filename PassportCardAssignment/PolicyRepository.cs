using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportCardAssignment;

internal class PolicyRepository
{
    private const string POLICY_FILE = "policy.json";

    public static Policy GetPolicy()
    {
        // load policy - open file policy.json
        try
        {
            string policyJson = File.ReadAllText(POLICY_FILE);

            var policy = JsonConvert.DeserializeObject<Policy>(policyJson,
                new StringEnumConverter());

            return policy;
        }
        catch (Exception)
        {
            throw new Exception($"Error parsing {POLICY_FILE}");
        }

    }
}
