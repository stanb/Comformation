using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.RuleGroup
{
    /// <summary>
    /// AWS::NetworkFirewall::RuleGroup StatelessRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-statelessrule.html
    /// </summary>
    public class StatelessRule
    {

        /// <summary>
        /// RuleDefinition
        /// Defines the stateless 5-tuple packet inspection criteria and the action to take on a packet that
        /// matches the criteria.
        /// Required: Yes
        /// Type: RuleDefinition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RuleDefinition")]
        public RuleDefinition RuleDefinition { get; set; }

        /// <summary>
        /// Priority
        /// A setting that indicates the order in which to run this rule relative to all of the rules that are
        /// defined for a stateless rule group. Network Firewall evaluates the rules in a rule group starting
        /// with the lowest priority setting. You must ensure that the priority settings are unique for the rule
        /// group.
        /// Each stateless rule group uses exactly one StatelessRulesAndCustomActions object, and each
        /// StatelessRulesAndCustomActions contains exactly one StatelessRules object. To ensure unique priority
        /// settings for your rule groups, set unique priorities for the stateless rules that you define inside
        /// any single StatelessRules object.
        /// You can change the priority settings of your rules at any time. To make it easier to insert rules
        /// later, number them so there&#39;s a wide range in between, for example use 100, 200, and so on.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 65535
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Priority")]
        public Union<int, IntrinsicFunction> Priority { get; set; }

    }
}
