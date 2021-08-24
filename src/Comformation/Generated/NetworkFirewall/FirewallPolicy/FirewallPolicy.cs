using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.FirewallPolicy
{
    /// <summary>
    /// AWS::NetworkFirewall::FirewallPolicy FirewallPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-firewallpolicy.html
    /// </summary>
    public class FirewallPolicy
    {

        /// <summary>
        /// StatelessDefaultActions
        /// The actions to take on a packet if it doesn&#39;t match any of the stateless rules in the policy. If you
        /// want non-matching packets to be forwarded for stateful inspection, specify aws:forward_to_sfe.
        /// You must specify one of the standard actions: aws:pass, aws:drop, or aws:forward_to_sfe. In
        /// addition, you can specify custom actions that are compatible with your standard section choice.
        /// For example, you could specify [&quot;aws:pass&quot;] or you could specify [&quot;aws:pass&quot;, “customActionName”].
        /// For information about compatibility, see the custom action descriptions.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StatelessDefaultActions")]
        public List<Union<string, IntrinsicFunction>> StatelessDefaultActions { get; set; }

        /// <summary>
        /// StatelessFragmentDefaultActions
        /// The actions to take on a fragmented packet if it doesn&#39;t match any of the stateless rules in the
        /// policy. If you want non-matching fragmented packets to be forwarded for stateful inspection, specify
        /// aws:forward_to_sfe.
        /// You must specify one of the standard actions: aws:pass, aws:drop, or aws:forward_to_sfe. In
        /// addition, you can specify custom actions that are compatible with your standard section choice.
        /// For example, you could specify [&quot;aws:pass&quot;] or you could specify [&quot;aws:pass&quot;, “customActionName”].
        /// For information about compatibility, see the custom action descriptions.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StatelessFragmentDefaultActions")]
        public List<Union<string, IntrinsicFunction>> StatelessFragmentDefaultActions { get; set; }

        /// <summary>
        /// StatelessCustomActions
        /// The custom action definitions that are available for use in the firewall policy&#39;s
        /// StatelessDefaultActions setting. You name each custom action that you define, and then you can use
        /// it by name in your default actions specifications.
        /// Required: No
        /// Type: List of CustomAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StatelessCustomActions")]
        public List<CustomAction> StatelessCustomActions { get; set; }

        /// <summary>
        /// StatelessRuleGroupReferences
        /// References to the stateless rule groups that are used in the policy. These define the matching
        /// criteria in stateless rules.
        /// Required: No
        /// Type: List of StatelessRuleGroupReference
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StatelessRuleGroupReferences")]
        public List<StatelessRuleGroupReference> StatelessRuleGroupReferences { get; set; }

        /// <summary>
        /// StatefulRuleGroupReferences
        /// References to the stateful rule groups that are used in the policy. These define the inspection
        /// criteria in stateful rules.
        /// Required: No
        /// Type: List of StatefulRuleGroupReference
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StatefulRuleGroupReferences")]
        public List<StatefulRuleGroupReference> StatefulRuleGroupReferences { get; set; }

    }
}
