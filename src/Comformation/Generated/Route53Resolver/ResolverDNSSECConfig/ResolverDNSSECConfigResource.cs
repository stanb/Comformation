using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53Resolver.ResolverDNSSECConfig
{
    /// <summary>
    /// AWS::Route53Resolver::ResolverDNSSECConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverdnssecconfig.html
    /// </summary>
    public class ResolverDNSSECConfigResource : ResourceBase
    {
        public class ResolverDNSSECConfigProperties
        {
            /// <summary>
            /// ResourceId
            /// 		
            /// The ID of the virtual private cloud (VPC) that you&#39;re configuring the DNSSEC validation status for.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ResourceId { get; set; }

        }

        public string Type { get; } = "AWS::Route53Resolver::ResolverDNSSECConfig";

        public ResolverDNSSECConfigProperties Properties { get; } = new ResolverDNSSECConfigProperties();

    }

    public static class ResolverDNSSECConfigAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> OwnerId = new ResourceAttribute<Union<string, IntrinsicFunction>>("OwnerId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ValidationStatus = new ResourceAttribute<Union<string, IntrinsicFunction>>("ValidationStatus");
    }
}
