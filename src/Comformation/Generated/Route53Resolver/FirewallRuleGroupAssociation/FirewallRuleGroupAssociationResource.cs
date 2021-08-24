using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53Resolver.FirewallRuleGroupAssociation
{
    /// <summary>
    /// AWS::Route53Resolver::FirewallRuleGroupAssociation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-firewallrulegroupassociation.html
    /// </summary>
    public class FirewallRuleGroupAssociationResource : ResourceBase
    {
        public class FirewallRuleGroupAssociationProperties
        {
            /// <summary>
            /// FirewallRuleGroupId
            /// The unique identifier of the firewall rule group.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> FirewallRuleGroupId { get; set; }

            /// <summary>
            /// VpcId
            /// The unique identifier of the VPC that is associated with the rule group.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> VpcId { get; set; }

            /// <summary>
            /// Name
            /// The name of the association.
            /// Required: No
            /// Type: String
            /// Maximum: 64
            /// Pattern: (?!^[0-9]+$)([a-zA-Z0-9\-_&#39; &#39;]+)
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Priority
            /// The setting that determines the processing order of the rule group among the rule groups that are
            /// associated with a single VPC. DNS Firewall filters VPC traffic starting from rule group with the
            /// lowest numeric priority setting.
            /// This value must equal 100-9,000.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> Priority { get; set; }

            /// <summary>
            /// MutationProtection
            /// If enabled, this setting disallows modification or removal of the association, to help prevent
            /// against accidentally altering DNS firewall protections.
            /// Required: No
            /// Type: String
            /// Allowed values: DISABLED | ENABLED
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> MutationProtection { get; set; }

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

        public string Type { get; } = "AWS::Route53Resolver::FirewallRuleGroupAssociation";

        public FirewallRuleGroupAssociationProperties Properties { get; } = new FirewallRuleGroupAssociationProperties();

    }

    public static class FirewallRuleGroupAssociationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ManagedOwnerName = new ResourceAttribute<Union<string, IntrinsicFunction>>("ManagedOwnerName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Status = new ResourceAttribute<Union<string, IntrinsicFunction>>("Status");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> StatusMessage = new ResourceAttribute<Union<string, IntrinsicFunction>>("StatusMessage");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreatorRequestId = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreatorRequestId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreationTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreationTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ModificationTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("ModificationTime");
    }
}
