using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPCCidrBlock
{
    /// <summary>
    /// AWS::EC2::VPCCidrBlock
    /// The AWS::EC2::VPCCidrBlock resource associates a single Amazon-provided IPv6 CIDR block or a single
    /// user-specified IPv4 CIDR block with a Virtual Private Cloud (VPC).
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpccidrblock.html
    /// </summary>
    public class VPCCidrBlockResource : ResourceBase
    {
        public class VPCCidrBlockProperties
        {
            /// <summary>
            /// AmazonProvidedIpv6CidrBlock
            /// Whether to request an Amazon-provided IPv6 CIDR block with a /56 prefix length for the VPC. You
            /// can&#39;t specify the range of IPv6 addresses or the size of the CIDR block.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> AmazonProvidedIpv6CidrBlock { get; set; }

            /// <summary>
            /// CidrBlock
            /// An IPv4 CIDR block to associate with the VPC.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CidrBlock { get; set; }

            /// <summary>
            /// VpcId
            /// The ID of the VPC to associate the Amazon-provided IPv6 CIDR block with.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> VpcId { get; set; }

        }

        public string Type { get; } = "AWS::EC2::VPCCidrBlock";

        public VPCCidrBlockProperties Properties { get; } = new VPCCidrBlockProperties();

    }
}
