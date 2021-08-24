using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.RuleGroup
{
    /// <summary>
    /// AWS::NetworkFirewall::RuleGroup PortSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-portset.html
    /// </summary>
    public class PortSet
    {

        /// <summary>
        /// Definition
        /// The set of port ranges.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Definition")]
        public List<Union<string, IntrinsicFunction>> Definition { get; set; }

    }
}
