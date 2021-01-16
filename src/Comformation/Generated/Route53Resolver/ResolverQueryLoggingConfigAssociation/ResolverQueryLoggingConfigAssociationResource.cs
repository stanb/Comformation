using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53Resolver.ResolverQueryLoggingConfigAssociation
{
    /// <summary>
    /// AWS::Route53Resolver::ResolverQueryLoggingConfigAssociation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverqueryloggingconfigassociation.html
    /// </summary>
    public class ResolverQueryLoggingConfigAssociationResource : ResourceBase
    {
        public class ResolverQueryLoggingConfigAssociationProperties
        {
            /// <summary>
            /// ResolverQueryLogConfigId
            /// 		
            /// The ID of the query logging configuration that a VPC is associated with.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ResolverQueryLogConfigId { get; set; }

            /// <summary>
            /// ResourceId
            /// 		
            /// The ID of the Amazon VPC that is associated with the query logging configuration.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ResourceId { get; set; }

        }

        public string Type { get; } = "AWS::Route53Resolver::ResolverQueryLoggingConfigAssociation";

        public ResolverQueryLoggingConfigAssociationProperties Properties { get; } = new ResolverQueryLoggingConfigAssociationProperties();

    }

    public static class ResolverQueryLoggingConfigAssociationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Status = new ResourceAttribute<Union<string, IntrinsicFunction>>("Status");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Error = new ResourceAttribute<Union<string, IntrinsicFunction>>("Error");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ErrorMessage = new ResourceAttribute<Union<string, IntrinsicFunction>>("ErrorMessage");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreationTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreationTime");
    }
}
