using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.RuleGroup
{
    /// <summary>
    /// AWS::NetworkFirewall::RuleGroup ActionDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-actiondefinition.html
    /// </summary>
    public class ActionDefinition
    {

        /// <summary>
        /// PublishMetricAction
        /// Stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch for the
        /// matching packet. This setting defines a CloudWatch dimension value to be published.
        /// You can pair this custom action with any of the standard stateless rule actions. For example, you
        /// could pair this in a rule action with the standard action that forwards the packet for stateful
        /// inspection. Then, when a packet matches the rule, Network Firewall publishes metrics for the packet
        /// and forwards it.
        /// Required: No
        /// Type: PublishMetricAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PublishMetricAction")]
        public PublishMetricAction PublishMetricAction { get; set; }

    }
}
