using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPC
{
    /// <summary>
    /// AWS::EC2::VPC
    /// Creates a Virtual Private Cloud (VPC) with the CIDR block that you specify. To name a VPC resource, use the
    /// Tags property and specify a value for the Name key.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html
    /// </summary>
    public class VPCResource : ResourceBase
    {
        public class VPCProperties
        {
            /// <summary>
            /// CidrBlock
            /// The CIDR block you want the VPC to cover. For example: "10. 0. 0. 0/16".
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-aws-ec2-vpc-cidrblock
            /// </summary>
			public Union<string, IntrinsicFunction> CidrBlock { get; set; }

            /// <summary>
            /// EnableDnsHostnames
            /// Specifies whether the instances launched in the VPC get DNS hostnames. If this attribute is true,
            /// instances in the VPC get DNS hostnames; otherwise, they do not. You can only set EnableDnsHostnames
            /// to true if you also set the EnableDnsSupport attribute to true. By default, the value is set to
            /// false.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-aws-ec2-vpc-EnableDnsHostnames
            /// </summary>
			public Union<bool, IntrinsicFunction> EnableDnsHostnames { get; set; }

            /// <summary>
            /// EnableDnsSupport
            /// Specifies whether DNS resolution is supported for the VPC. If this attribute is true, the Amazon DNS
            /// server resolves DNS hostnames for your instances to their corresponding IP addresses; otherwise, it
            /// does not. By default the value is set to true.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-aws-ec2-vpc-EnableDnsSupport
            /// </summary>
			public Union<bool, IntrinsicFunction> EnableDnsSupport { get; set; }

            /// <summary>
            /// InstanceTenancy
            /// The allowed tenancy of instances launched into the VPC.
            /// "default": Instances can be launched with any tenancy. "dedicated": Any instance launched into the
            /// VPC automatically has dedicated tenancy, unless you launch it with the default tenancy.
            /// Update: Conditional. Updating InstanceTenancy requires no replacement only if you are updating its
            /// value from "dedicated" to "default". Updating InstanceTenancy from "default" to "dedicated" requires
            /// replacement.
            /// Required: No
            /// Type: String
            /// Valid values: "default" or "dedicated"
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-aws-ec2-vpc-instancetenancy
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceTenancy { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this VPC. To name a VPC resource, specify a value for
            /// the Name key.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-aws-ec2-vpc-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::VPC";
        
        public VPCProperties Properties { get; } = new VPCProperties();
    }

	public static class VPCAttributes
	{
        public static readonly ResourceAttribute<string> CidrBlock = new ResourceAttribute<string>("CidrBlock");
        public static readonly ResourceAttribute<List<string>> CidrBlockAssociations = new ResourceAttribute<List<string>>("CidrBlockAssociations");
        public static readonly ResourceAttribute<string> DefaultNetworkAcl = new ResourceAttribute<string>("DefaultNetworkAcl");
        public static readonly ResourceAttribute<string> DefaultSecurityGroup = new ResourceAttribute<string>("DefaultSecurityGroup");
        public static readonly ResourceAttribute<List<string>> Ipv6CidrBlocks = new ResourceAttribute<List<string>>("Ipv6CidrBlocks");
	}
}
