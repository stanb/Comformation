using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Subnet
{
    /// <summary>
    /// AWS::EC2::Subnet
    /// Creates a subnet in an existing VPC.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html
    /// </summary>
    public class SubnetResource : ResourceBase
    {
        public class SubnetProperties
        {
            /// <summary>
            /// AssignIpv6AddressOnCreation
            /// Indicates whether a network interface created in this subnet receives an IPv6 address. The default
            /// value is false.
            /// Required: Conditional. If you specify a true or false value for AssignIpv6AddressOnCreation,
            /// Ipv6CidrBlock must also be specified.
            /// Type: Boolean
            /// Update requires: No interruption
            /// Note If AssignIpv6AddressOnCreation is specified, MapPublicIpOnLaunch cannot be specified.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-assignipv6addressoncreation
            /// </summary>
			public Union<bool, IntrinsicFunction> AssignIpv6AddressOnCreation { get; set; }

            /// <summary>
            /// AvailabilityZone
            /// The availability zone in which you want the subnet. Default: AWS selects a zone for you
            /// (recommended).
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// Note If you update this property, you must also update the CidrBlock property.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-availabilityzone
            /// </summary>
			public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// CidrBlock
            /// The CIDR block that you want the subnet to cover (for example, "10. 0. 0. 0/24").
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// Note If you update this property, you must also update the AvailabilityZone property.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-cidrblock
            /// </summary>
			public Union<string, IntrinsicFunction> CidrBlock { get; set; }

            /// <summary>
            /// Ipv6CidrBlock
            /// The IPv6 network range for the subnet, in CIDR notation. The subnet size must use a /64 prefix
            /// length.
            /// Required: Conditional. If you specify a true or false value for AssignIpv6AddressOnCreation,
            /// Ipv6CidrBlock must be specified.
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-ipv6cidrblock
            /// </summary>
			public Union<string, IntrinsicFunction> Ipv6CidrBlock { get; set; }

            /// <summary>
            /// MapPublicIpOnLaunch
            /// Indicates whether instances that are launched in this subnet receive a public IP address. By
            /// default, the value is false.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// Note If MapPublicIpOnLaunch is specified. AssignIpv6AddressOnCreation cannot be specified.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-mappubliciponlaunch
            /// </summary>
			public Union<bool, IntrinsicFunction> MapPublicIpOnLaunch { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this subnet.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// VpcId
            /// A Ref structure that contains the ID of the VPC on which you want to create the subnet. The VPC ID
            /// is provided as the value of the "Ref" property, as: { "Ref": "VPCID" }.
            /// Required: Yes
            /// Type: Ref ID
            /// Update requires: Replacement
            /// Note If you update this property, you must also update the CidrBlock property.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-awsec2subnet-prop-vpcid
            /// </summary>
			public Union<string, IntrinsicFunction> VpcId { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::Subnet";
        
        public SubnetProperties Properties { get; } = new SubnetProperties();
    }

	public static class SubnetAttributes
	{
        public static readonly ResourceAttribute<string> AvailabilityZone = new ResourceAttribute<string>("AvailabilityZone");
        public static readonly ResourceAttribute<List<string>> Ipv6CidrBlocks = new ResourceAttribute<List<string>>("Ipv6CidrBlocks");
        public static readonly ResourceAttribute<string> NetworkAclAssociationId = new ResourceAttribute<string>("NetworkAclAssociationId");
        public static readonly ResourceAttribute<string> VpcId = new ResourceAttribute<string>("VpcId");
	}
}
