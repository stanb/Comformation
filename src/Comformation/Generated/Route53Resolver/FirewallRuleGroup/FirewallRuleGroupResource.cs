using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53Resolver.FirewallRuleGroup
{
    /// <summary>
    /// AWS::Route53Resolver::FirewallRuleGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-firewallrulegroup.html
    /// </summary>
    public class FirewallRuleGroupResource : ResourceBase
    {
        public class FirewallRuleGroupProperties
        {
            /// <summary>
            /// Name
            /// The name of the rule group.
            /// Required: No
            /// Type: String
            /// Maximum: 64
            /// Pattern: (?!^[0-9]+$)([a-zA-Z0-9\-_&#39; &#39;]+)
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// FirewallRules
            /// A list of the rules that you have defined.
            /// Required: No
            /// Type: List of FirewallRule
            /// Update requires: No interruption
            /// </summary>
            public List<FirewallRule> FirewallRules { get; set; }

            /// <summary>
            /// Tags
            /// A list of the tag keys and values that you want to associate with the rule group.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 200
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Route53Resolver::FirewallRuleGroup";

        public FirewallRuleGroupProperties Properties { get; } = new FirewallRuleGroupProperties();

    }

    public static class FirewallRuleGroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> RuleCount = new ResourceAttribute<Union<int, IntrinsicFunction>>("RuleCount");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Status = new ResourceAttribute<Union<string, IntrinsicFunction>>("Status");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> StatusMessage = new ResourceAttribute<Union<string, IntrinsicFunction>>("StatusMessage");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> OwnerId = new ResourceAttribute<Union<string, IntrinsicFunction>>("OwnerId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ShareStatus = new ResourceAttribute<Union<string, IntrinsicFunction>>("ShareStatus");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreatorRequestId = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreatorRequestId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreationTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreationTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ModificationTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("ModificationTime");
    }
}
