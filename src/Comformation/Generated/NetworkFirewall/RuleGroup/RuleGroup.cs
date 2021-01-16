using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.RuleGroup
{
    /// <summary>
    /// AWS::NetworkFirewall::RuleGroup RuleGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulegroup.html
    /// </summary>
    public class RuleGroup
    {

        /// <summary>
        /// RuleVariables
        /// Settings that are available for use in the rules in the rule group. You can only use these for
        /// stateful rule groups.
        /// Required: No
        /// Type: RuleVariables
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RuleVariables")]
        public RuleVariables RuleVariables { get; set; }

        /// <summary>
        /// RulesSource
        /// The stateful rules or stateless rules for the rule group.
        /// Required: Yes
        /// Type: RulesSource
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RulesSource")]
        public RulesSource RulesSource { get; set; }

    }
}
