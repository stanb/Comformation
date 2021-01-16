using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.RuleGroup
{
    /// <summary>
    /// AWS::NetworkFirewall::RuleGroup RuleOption
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-ruleoption.html
    /// </summary>
    public class RuleOption
    {

        /// <summary>
        /// Keyword
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Keyword")]
        public Union<string, IntrinsicFunction> Keyword { get; set; }

        /// <summary>
        /// Settings
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Settings")]
        public List<Union<string, IntrinsicFunction>> Settings { get; set; }

    }
}
