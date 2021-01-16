using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.RuleGroup
{
    /// <summary>
    /// AWS::NetworkFirewall::RuleGroup RuleVariables
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulevariables.html
    /// </summary>
    public class RuleVariables
    {

        /// <summary>
        /// IPSets
        /// A list of IP addresses and address ranges, in CIDR notation.
        /// Required: No
        /// Type: Map of IPSet
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IPSets")]
        public Dictionary<string, IPSet> IPSets { get; set; }

        /// <summary>
        /// PortSets
        /// A list of port ranges.
        /// Required: No
        /// Type: Map of PortSet
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PortSets")]
        public Dictionary<string, PortSet> PortSets { get; set; }

    }
}
