using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.FirewallPolicy
{
    /// <summary>
    /// AWS::NetworkFirewall::FirewallPolicy StatefulRuleGroupReference
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-statefulrulegroupreference.html
    /// </summary>
    public class StatefulRuleGroupReference
    {

        /// <summary>
        /// ResourceArn
        /// The Amazon Resource Name (ARN) of the stateful rule group.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Pattern: ^arn:aws. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceArn")]
        public Union<string, IntrinsicFunction> ResourceArn { get; set; }

    }
}
