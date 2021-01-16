using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.FirewallPolicy
{
    /// <summary>
    /// AWS::NetworkFirewall::FirewallPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewallpolicy.html
    /// </summary>
    public class FirewallPolicyResource : ResourceBase
    {
        public class FirewallPolicyProperties
        {
            /// <summary>
            /// FirewallPolicyName
            /// The descriptive name of the firewall policy. You can&#39;t change the name of a firewall policy after
            /// you create it.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: ^[a-zA-Z0-9-]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> FirewallPolicyName { get; set; }

            /// <summary>
            /// FirewallPolicy
            /// The traffic filtering behavior of a firewall policy, defined in a collection of stateless and
            /// stateful rule groups and other settings.
            /// Required: Yes
            /// Type: FirewallPolicy
            /// Update requires: No interruption
            /// </summary>
            public FirewallPolicy FirewallPolicy { get; set; }

            /// <summary>
            /// Description
            /// A description of the firewall policy.
            /// Required: No
            /// Type: String
            /// Maximum: 512
            /// Pattern: ^. *$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 200
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::NetworkFirewall::FirewallPolicy";

        public FirewallPolicyProperties Properties { get; } = new FirewallPolicyProperties();

    }

    public static class FirewallPolicyAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> FirewallPolicyArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("FirewallPolicyArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> FirewallPolicyId = new ResourceAttribute<Union<string, IntrinsicFunction>>("FirewallPolicyId");
    }
}
