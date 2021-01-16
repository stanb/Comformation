using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.RuleGroup
{
    /// <summary>
    /// AWS::NetworkFirewall::RuleGroup RulesSource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulessource.html
    /// </summary>
    public class RulesSource
    {

        /// <summary>
        /// RulesString
        /// Stateful inspection criteria, provided in Suricata compatible intrusion prevention system (IPS)
        /// rules. Suricata is an open-source network IPS that includes a standard rule-based language for
        /// network traffic inspection.
        /// These rules contain the inspection criteria and the action to take for traffic that matches the
        /// criteria, so this type of rule group doesn&#39;t have a separate action setting.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 1000000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RulesString")]
        public Union<string, IntrinsicFunction> RulesString { get; set; }

        /// <summary>
        /// RulesSourceList
        /// Stateful inspection criteria for a domain list rule group.
        /// Required: No
        /// Type: RulesSourceList
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RulesSourceList")]
        public RulesSourceList RulesSourceList { get; set; }

        /// <summary>
        /// StatefulRules
        /// The 5-tuple stateful inspection criteria. This contains an array of individual 5-tuple stateful
        /// rules to be used together in a stateful rule group.
        /// Required: No
        /// Type: StatefulRules
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StatefulRules")]
        public List<StatefulRule> StatefulRules { get; set; }

        /// <summary>
        /// StatelessRulesAndCustomActions
        /// Stateless inspection criteria to be used in a stateless rule group.
        /// Required: No
        /// Type: StatelessRulesAndCustomActions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StatelessRulesAndCustomActions")]
        public StatelessRulesAndCustomActions StatelessRulesAndCustomActions { get; set; }

    }
}
