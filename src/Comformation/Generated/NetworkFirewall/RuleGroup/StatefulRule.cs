using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.RuleGroup
{
    /// <summary>
    /// AWS::NetworkFirewall::RuleGroup StatefulRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-statefulrule.html
    /// </summary>
    public class StatefulRule
    {

        /// <summary>
        /// Action
        /// Defines what Network Firewall should do with the packets in a traffic flow when the flow matches the
        /// stateful rule criteria. For all actions, Network Firewall performs the specified action and
        /// discontinues stateful inspection of the traffic flow.
        /// The actions for a stateful rule are defined as follows:
        /// PASS - Permits the packets to go to the intended destination. DROP - Blocks the packets from going
        /// to the intended destination and sends an alert log message, if alert logging is configured in the
        /// firewall&#39;s AWS::NetworkFirewall::LoggingConfiguration. ALERT - Permits the packets to go to the
        /// intended destination and sends an alert log message, if alert logging is configured in the
        /// firewall&#39;s AWS::NetworkFirewall::LoggingConfiguration. You can use this action to test a rule that
        /// you intend to use to drop traffic. You can enable the rule with ALERT action, verify in the logs
        /// that the rule is filtering as you want, then change the action to DROP.
        /// Required: Yes
        /// Type: String
        /// Allowed values: ALERT | DROP | PASS
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public Union<string, IntrinsicFunction> Action { get; set; }

        /// <summary>
        /// Header
        /// The stateful 5-tuple inspection criteria for this rule, used to inspect traffic flows.
        /// Required: Yes
        /// Type: Header
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Header")]
        public Header Header { get; set; }

        /// <summary>
        /// RuleOptions
        /// Additional settings for a stateful rule, provided as keywords and settings.
        /// Required: Yes
        /// Type: RuleOptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RuleOptions")]
        public List<RuleOption> RuleOptions { get; set; }

    }
}
