using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPC
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html
    /// </summary>
    public class VPCResource : ResourceBase
    {
        public class VPCProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-aws-ec2-vpc-cidrblock
            /// </summary>
			public Union<string, IntrinsicFunction> CidrBlock { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-aws-ec2-vpc-EnableDnsHostnames
            /// </summary>
			public Union<bool, IntrinsicFunction> EnableDnsHostnames { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-aws-ec2-vpc-EnableDnsSupport
            /// </summary>
			public Union<bool, IntrinsicFunction> EnableDnsSupport { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-aws-ec2-vpc-instancetenancy
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceTenancy { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-aws-ec2-vpc-tags
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
