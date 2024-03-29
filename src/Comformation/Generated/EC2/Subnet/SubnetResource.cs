using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Subnet
{
    /// <summary>
    /// AWS::EC2::Subnet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html
    /// </summary>
    public class SubnetResource : ResourceBase
    {
        public class SubnetProperties
        {
            /// <summary>
            /// AssignIpv6AddressOnCreation
            /// Indicates whether a network interface created in this subnet receives an IPv6 address. The default
            /// value is false.
            /// If you specify AssignIpv6AddressOnCreation, you must also specify Ipv6CidrBlock.
            /// If you specify AssignIpv6AddressOnCreation, you cannot specify MapPublicIpOnLaunch.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AssignIpv6AddressOnCreation { get; set; }

            /// <summary>
            /// AvailabilityZone
            /// 	
            /// The Availability Zone of the subnet.
            /// If you update this property, you must also update the CidrBlock property.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// CidrBlock
            /// 	
            /// The IPv4 CIDR block assigned to the subnet.
            /// If you update this property, we create a new subnet, and then delete the existing one.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CidrBlock { get; set; }

            /// <summary>
            /// Ipv6CidrBlock
            /// The IPv6 CIDR block.
            /// If you specify AssignIpv6AddressOnCreation, you must also specify Ipv6CidrBlock.
            /// Required: Conditional
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Ipv6CidrBlock { get; set; }

            /// <summary>
            /// MapPublicIpOnLaunch
            /// Indicates whether instances launched in this subnet receive a public IPv4 address. The default value
            /// is false.
            /// If you specify MapPublicIpOnLaunch, you cannot specify AssignIpv6AddressOnCreation.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> MapPublicIpOnLaunch { get; set; }

            /// <summary>
            /// OutpostArn
            /// The Amazon Resource Name (ARN) of the Outpost.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> OutpostArn { get; set; }

            /// <summary>
            /// Tags
            /// 	
            /// Any tags assigned to the subnet.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// VpcId
            /// 	
            /// The ID of the VPC the subnet is in.
            /// If you update this property, you must also update the CidrBlock property.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> VpcId { get; set; }

        }

        public string Type { get; } = "AWS::EC2::Subnet";

        public SubnetProperties Properties { get; } = new SubnetProperties();

    }

    public static class SubnetAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AvailabilityZone = new ResourceAttribute<Union<string, IntrinsicFunction>>("AvailabilityZone");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> Ipv6CidrBlocks = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("Ipv6CidrBlocks");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> NetworkAclAssociationId = new ResourceAttribute<Union<string, IntrinsicFunction>>("NetworkAclAssociationId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> OutpostArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("OutpostArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> VpcId = new ResourceAttribute<Union<string, IntrinsicFunction>>("VpcId");
    }
}
