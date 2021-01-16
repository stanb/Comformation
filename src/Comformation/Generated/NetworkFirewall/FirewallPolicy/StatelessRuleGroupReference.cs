using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.FirewallPolicy
{
    /// <summary>
    /// AWS::NetworkFirewall::FirewallPolicy StatelessRuleGroupReference
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-statelessrulegroupreference.html
    /// </summary>
    public class StatelessRuleGroupReference
    {

        /// <summary>
        /// ResourceArn
        /// The Amazon Resource Name (ARN) of the stateless rule group.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Pattern: ^arn:aws. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceArn")]
        public Union<string, IntrinsicFunction> ResourceArn { get; set; }

        /// <summary>
        /// Priority
        /// An integer setting that indicates the order in which to run the stateless rule groups in a single
        /// AWS::NetworkFirewall::FirewallPolicy. Network Firewall applies each stateless rule group to a packet
        /// starting with the group that has the lowest priority setting. You must ensure that the priority
        /// settings are unique within each policy.
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
