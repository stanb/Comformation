using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53Resolver.ResolverEndpoint
{
    /// <summary>
    /// AWS::Route53Resolver::ResolverEndpoint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverendpoint.html
    /// </summary>
    public class ResolverEndpointResource : ResourceBase
    {
        public class ResolverEndpointProperties
        {
            /// <summary>
            /// IpAddresses
            /// 		
            /// The subnets and IP addresses in your VPC that DNS queries originate from (for outbound endpoints) or
            /// that you forward 			DNS queries to (for inbound endpoints). The subnet ID uniquely identifies a VPC.
            /// 	
            /// Required: Yes
            /// Type: List of IpAddressRequest
            /// Maximum: 10
            /// Update requires: No interruption
            /// </summary>
            public List<IpAddressRequest> IpAddresses { get; set; }

            /// <summary>
            /// Direction
            /// 		
            /// Indicates whether the Resolver endpoint allows inbound or outbound DNS queries:
            /// 		
            /// 			 			 		 INBOUND: allows DNS queries to your VPC from your network OUTBOUND: allows DNS queries
            /// from your VPC to your network
            /// 	
            /// Required: Yes
            /// Type: String
            /// Allowed values: INBOUND | OUTBOUND
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Direction { get; set; }

            /// <summary>
            /// SecurityGroupIds
            /// 		
            /// The ID of one or more security groups that control access to this VPC. The security group must
            /// include one or more inbound rules 			(for inbound endpoints) or outbound rules (for outbound
            /// endpoints). Inbound and outbound rules must allow TCP and UDP access. 			For inbound access, open
            /// port 53. For outbound access, open the port that you&#39;re using for DNS queries on your network.
            /// 	
            /// Required: Yes
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

            /// <summary>
            /// Tags
            /// 	
            /// Route 53 Resolver doesn&#39;t support updating tags through CloudFormation.
            /// 	
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 200
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// 		
            /// A friendly name that lets you easily find a configuration in the Resolver dashboard in the Route 53
            /// console.
            /// 	
            /// Required: No
            /// Type: String
            /// Maximum: 64
            /// Pattern: (?!^[0-9]+$)([a-zA-Z0-9\-_&#39; &#39;]+)
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
