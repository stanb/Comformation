using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPC
{
    /// <summary>
    /// AWS::EC2::VPC
    /// Specifies a VPC with the specified IPv4 CIDR block. The smallest VPC you can create 			uses a /28 netmask (16
    /// IPv4 addresses), and the largest uses a /16 netmask (65,536 IPv4 			addresses). For more information about how
    /// large to make your VPC, see Your VPC and 		 Subnets in the Amazon Virtual Private Cloud User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html
    /// </summary>
    public class VPCResource : ResourceBase
    {
        public class VPCProperties
        {
            /// <summary>
            /// CidrBlock
            /// 		
            /// The primary IPv4 CIDR block for the VPC.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CidrBlock { get; set; }

            /// <summary>
            /// EnableDnsHostnames
            /// Indicates whether the instances launched in the VPC get DNS hostnames. If enabled, instances in the
            /// VPC get DNS hostnames; otherwise, they do not.
            /// You can only enable DNS hostnames if you&#39;ve enabled DNS support.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> EnableDnsHostnames { get; set; }

            /// <summary>
            /// EnableDnsSupport
            /// 		
            /// Indicates whether the DNS resolution is supported for the VPC. If enabled, queries to 			the Amazon
            /// provided DNS server at the 169. 254. 169. 253 IP address, or the reserved IP 			address at the base
            /// of the VPC network range &quot;plus two&quot; succeed. If disabled, the Amazon 			provided DNS service in the
            /// VPC that resolves public DNS hostnames to IP addresses is 			not enabled.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> EnableDnsSupport { get; set; }

            /// <summary>
            /// InstanceTenancy
            /// The allowed tenancy of instances launched into the VPC.
            /// &quot;default&quot;: Instances can be launched with any tenancy. &quot;dedicated&quot;: Any instance launched into the
            /// VPC automatically has dedicated tenancy, unless you launch it with the default tenancy.
            /// Updating InstanceTenancy requires no replacement only if you are updating its value from &quot;dedicated&quot;
            /// to &quot;default&quot;. Updating InstanceTenancy from &quot;default&quot; to &quot;dedicated&quot; requires replacement.
            /// Required: No
            /// Type: String
            /// Allowed Values: dedicated | default | host
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceTenancy { get; set; }

            /// <summary>
            /// Tags
            /// 	
            /// The tags for the VPC.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EC2::VPC";

        public VPCProperties Properties { get; } = new VPCProperties();

    }

	public static class VPCAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CidrBlock = new ResourceAttribute<Union<string, IntrinsicFunction>>("CidrBlock");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> CidrBlockAssociations = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("CidrBlockAssociations");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DefaultNetworkAcl = new ResourceAttribute<Union<string, IntrinsicFunction>>("DefaultNetworkAcl");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DefaultSecurityGroup = new ResourceAttribute<Union<string, IntrinsicFunction>>("DefaultSecurityGroup");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> Ipv6CidrBlocks = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("Ipv6CidrBlocks");
	}
}
