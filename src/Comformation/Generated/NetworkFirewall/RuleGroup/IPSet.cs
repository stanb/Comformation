using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.RuleGroup
{
    /// <summary>
    /// AWS::NetworkFirewall::RuleGroup IPSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-ipset.html
    /// </summary>
    public class IPSet
    {

        /// <summary>
        /// Definition
        /// The list of IP addresses and address ranges, in CIDR notation.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Definition")]
        public List<Union<string, IntrinsicFunction>> Definition { get; set; }

    }
}
