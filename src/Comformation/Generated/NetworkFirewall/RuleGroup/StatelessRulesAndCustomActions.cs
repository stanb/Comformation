using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.RuleGroup
{
    /// <summary>
    /// AWS::NetworkFirewall::RuleGroup StatelessRulesAndCustomActions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-statelessrulesandcustomactions.html
    /// </summary>
    public class StatelessRulesAndCustomActions
    {

        /// <summary>
        /// StatelessRules
        /// Defines the set of stateless rules for use in a stateless rule group.
        /// Required: Yes
        /// Type: StatelessRules
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StatelessRules")]
        public List<StatelessRule> StatelessRules { get; set; }

        /// <summary>
        /// CustomActions
        /// Defines an array of individual custom action definitions that are available for use by the stateless
        /// rules in this StatelessRulesAndCustomActions specification. You name each custom action that you
        /// define, and then you can use it by name in your stateless rule AWS::NetworkFirewall::RuleGroup
        /// RuleDefinition Actions specification.
        /// Required: No
        /// Type: CustomActions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomActions")]
        public List<CustomAction> CustomActions { get; set; }

    }
}
