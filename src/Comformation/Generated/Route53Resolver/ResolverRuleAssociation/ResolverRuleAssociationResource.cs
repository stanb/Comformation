using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53Resolver.ResolverRuleAssociation
{
    /// <summary>
    /// AWS::Route53Resolver::ResolverRuleAssociation
    /// The AWS::Route53Resolver::ResolverRuleAssociation resource contains information about an association between a
    /// resolver rule and a VPC. 	For more information, see 	ResolverRuleAssociation in the 	Amazon Route 53 API
    /// Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverruleassociation.html
    /// </summary>
    public class ResolverRuleAssociationResource : ResourceBase
    {
        public class ResolverRuleAssociationProperties
        {
            /// <summary>
            /// VPCId
            /// 	
            /// The ID of the VPC that you associated the resolver rule with.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> VPCId { get; set; }

            /// <summary>
            /// ResolverRuleId
            /// 	
            /// The ID of the resolver rule that you associated with the VPC that is specified by VPCId.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ResolverRuleId { get; set; }

            /// <summary>
            /// Name
            /// 	
            /// The name of an association between a resolver rule and a VPC.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Route53Resolver::ResolverRuleAssociation";

        public ResolverRuleAssociationProperties Properties { get; } = new ResolverRuleAssociationProperties();

    }

	public static class ResolverRuleAssociationAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> VPCId = new ResourceAttribute<Union<string, IntrinsicFunction>>("VPCId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ResolverRuleId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ResolverRuleId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ResolverRuleAssociationId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ResolverRuleAssociationId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
	}
}
