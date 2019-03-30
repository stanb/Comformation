using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53Resolver.ResolverEndpoint
{
    /// <summary>
    /// AWS::Route53Resolver::ResolverEndpoint
    /// The 	AWS::Route53Resolver::ResolverEndpoint resource includes settings for inbound or outbound endpoints for
    /// Amazon Route&#160;53. 	For more information, see ResolverEndpoint in the 	Amazon Route&#160;53 API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverendpoint.html
    /// </summary>
    public class ResolverEndpointResource : ResourceBase
    {
        public class ResolverEndpointProperties
        {
            /// <summary>
            /// IpAddresses
            /// 	
            /// The subnets and IP addresses in your VPC that you want DNS queries to pass through on the way from
            /// your VPCs 		to your network (for outbound endpoints) or on the way from your network to your VPCs
            /// (for inbound resolver endpoints).
            /// Required: Yes
            /// Type: List of IpAddressRequest property types
            /// Update requires: No interruption
            /// </summary>
			public List<IpAddressRequest> IpAddresses { get; set; }

            /// <summary>
            /// Direction
            /// 	
            /// Indicates whether the resolver endpoint allows inbound or outbound DNS queries.
            /// Valid values:INBOUND | OUTBOUND
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Direction { get; set; }

            /// <summary>
            /// SecurityGroupIds
            /// 	
            /// The ID of one or more security groups that you want to use to control access to this VPC. The
            /// security group 		that you specify must include one or more inbound rules (for inbound resolver
            /// endpoints) or outbound rules 		(for outbound resolver endpoints).
            /// Required: Yes
            /// Type: List of String values
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

            /// <summary>
            /// Tags
            /// 	
            /// A list of the tag keys and values that you want to associate with the endpoint.
            /// Required: No
            /// Type: List of Resource Tag property types
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// 	
            /// A friendly name that lets you easily find a configuration in the Resolver dashboard in the Route 53
            /// console.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Route53Resolver::ResolverEndpoint";

        public ResolverEndpointProperties Properties { get; } = new ResolverEndpointProperties();

    }

	public static class ResolverEndpointAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ResolverEndpointId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ResolverEndpointId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> IpAddressCount = new ResourceAttribute<Union<string, IntrinsicFunction>>("IpAddressCount");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Direction = new ResourceAttribute<Union<string, IntrinsicFunction>>("Direction");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> HostVPCId = new ResourceAttribute<Union<string, IntrinsicFunction>>("HostVPCId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
	}
}
