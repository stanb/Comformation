using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.Firewall
{
    /// <summary>
    /// AWS::NetworkFirewall::Firewall
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewall.html
    /// </summary>
    public class FirewallResource : ResourceBase
    {
        public class FirewallProperties
        {
            /// <summary>
            /// FirewallName
            /// The descriptive name of the firewall. You can&#39;t change the name of a firewall after you create it.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: ^[a-zA-Z0-9-]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> FirewallName { get; set; }

            /// <summary>
            /// FirewallPolicyArn
            /// The Amazon Resource Name (ARN) of the firewall policy.
            /// The relationship of firewall to firewall policy is many to one. Each firewall requires one firewall
            /// policy association, and you can use the same firewall policy for multiple firewalls.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: ^arn:aws. *
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> FirewallPolicyArn { get; set; }

            /// <summary>
            /// VpcId
            /// The unique identifier of the VPC where the firewall is in use. You can&#39;t change the VPC of a
            /// firewall after you create the firewall.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: ^vpc-[0-9a-f]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> VpcId { get; set; }

            /// <summary>
            /// SubnetMappings
            /// The public subnets that Network Firewall is using for the firewall. Each subnet must belong to a
            /// different Availability Zone.
            /// Required: Yes
            /// Type: List of SubnetMapping
            /// Update requires: No interruption
            /// </summary>
            public List<SubnetMapping> SubnetMappings { get; set; }

            /// <summary>
            /// DeleteProtection
            /// A flag indicating whether it is possible to delete the firewall. A setting of TRUE indicates that
            /// the firewall is protected against deletion. Use this setting to protect against accidentally
            /// deleting a firewall that is in use. When you create a firewall, the operation initializes this flag
            /// to TRUE.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> DeleteProtection { get; set; }

            /// <summary>
            /// SubnetChangeProtection
            /// A setting indicating whether the firewall is protected against changes to the subnet associations.
            /// Use this setting to protect against accidentally modifying the subnet associations for a firewall
            /// that is in use. When you create a firewall, the operation initializes this setting to TRUE.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> SubnetChangeProtection { get; set; }

            /// <summary>
            /// FirewallPolicyChangeProtection
            /// A setting indicating whether the firewall is protected against a change to the firewall policy
            /// association. Use this setting to protect against accidentally modifying the firewall policy for a
            /// firewall that is in use. When you create a firewall, the operation initializes this setting to TRUE.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> FirewallPolicyChangeProtection { get; set; }

            /// <summary>
            /// Description
            /// A description of the firewall.
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
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::NetworkFirewall::Firewall";

        public FirewallProperties Properties { get; } = new FirewallProperties();

    }

    public static class FirewallAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> FirewallArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("FirewallArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> FirewallId = new ResourceAttribute<Union<string, IntrinsicFunction>>("FirewallId");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> EndpointIds = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("EndpointIds");
    }
}
