using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.RuleGroup
{
    /// <summary>
    /// AWS::NetworkFirewall::RuleGroup RuleDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-ruledefinition.html
    /// </summary>
    public class RuleDefinition
    {

        /// <summary>
        /// MatchAttributes
        /// Criteria for Network Firewall to use to inspect an individual packet in stateless rule inspection.
        /// Each match attributes set can include one or more items such as IP address, CIDR range, port number,
        /// protocol, and TCP flags.
        /// Required: Yes
        /// Type: MatchAttributes
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MatchAttributes")]
        public MatchAttributes MatchAttributes { get; set; }

        /// <summary>
        /// Actions
        /// The actions to take on a packet that matches one of the stateless rule definition&#39;s match
        /// attributes. You must specify a standard action and you can add custom actions.
        /// Note Network Firewall only forwards a packet for stateful rule inspection if you specify
        /// aws:forward_to_sfe for a rule that the packet matches, or if the packet doesn&#39;t match any stateless
        /// rule and you specify aws:forward_to_sfe for the StatelessDefaultActions setting for the
        /// AWS::NetworkFirewall::FirewallPolicy.
        /// For every rule, you must specify exactly one of the following standard actions.
        /// aws:pass - Discontinues all inspection of the packet and permits it to go to its intended
        /// destination. aws:drop - Discontinues all inspection of the packet and blocks it from going to its
        /// intended destination. aws:forward_to_sfe - Discontinues stateless inspection of the packet and
        /// forwards it to the stateful rule engine for inspection.
        /// Additionally, you can specify a custom action. To do this, you define a custom action by name and
        /// type, then provide the name you&#39;ve assigned to the action in this Actions setting.
        /// To provide more than one action in this setting, separate the settings with a comma. For example, if
        /// you have a publish metrics custom action that you&#39;ve named MyMetricsAction, then you could specify
        /// the standard action aws:pass combined with the custom action using [“aws:pass”, “MyMetricsAction”].
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Actions")]
        public List<Union<string, IntrinsicFunction>> Actions { get; set; }

    }
}
