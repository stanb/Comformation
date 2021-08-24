using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.RuleGroup
{
    /// <summary>
    /// AWS::NetworkFirewall::RuleGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-rulegroup.html
    /// </summary>
    public class RuleGroupResource : ResourceBase
    {
        public class RuleGroupProperties
        {
            /// <summary>
            /// RuleGroupName
            /// The descriptive name of the rule group. You can&#39;t change the name of a rule group after you create
            /// it.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: ^[a-zA-Z0-9-]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RuleGroupName { get; set; }

            /// <summary>
            /// RuleGroup
            /// An object that defines the rule group rules.
            /// Required: No
            /// Type: RuleGroup
            /// Update requires: No interruption
            /// </summary>
            public RuleGroup RuleGroup { get; set; }

            /// <summary>
            /// Type
            /// Indicates whether the rule group is stateless or stateful. If the rule group is stateless, it
            /// contains stateless rules. If it is stateful, it contains stateful rules.
            /// Required: Yes
            /// Type: String
            /// Allowed values: STATEFUL | STATELESS
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// Capacity
            /// The maximum operating resources that this rule group can use. You can&#39;t change a rule group&#39;s
            /// capacity setting after you create the rule group. When you update a rule group, you are limited to
            /// this capacity. When you reference a rule group from a firewall policy, Network Firewall reserves
            /// this capacity for the rule group.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
            public Union<int, IntrinsicFunction> Capacity { get; set; }

            /// <summary>
            /// Description
            /// A description of the rule group.
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

        public string Type { get; } = "AWS::NetworkFirewall::RuleGroup";

        public RuleGroupProperties Properties { get; } = new RuleGroupProperties();

    }

    public static class RuleGroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RuleGroupArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("RuleGroupArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RuleGroupId = new ResourceAttribute<Union<string, IntrinsicFunction>>("RuleGroupId");
    }
}
