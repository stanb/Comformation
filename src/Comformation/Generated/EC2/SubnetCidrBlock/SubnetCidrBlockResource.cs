using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SubnetCidrBlock
{
    /// <summary>
    /// AWS::EC2::SubnetCidrBlock
    /// The AWS::EC2::SubnetCidrBlock resource associates a single IPv6 CIDR block with an Amazon VPC subnet.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnetcidrblock.html
    /// </summary>
    public class SubnetCidrBlockResource : ResourceBase
    {
        public class SubnetCidrBlockProperties
        {
            /// <summary>
            /// Ipv6CidrBlock
            /// The IPv6 CIDR block for the subnet. The CIDR block must have a prefix length of /64.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Ipv6CidrBlock { get; set; }

            /// <summary>
            /// SubnetId
            /// The ID of the subnet to associate the IPv6 CIDR block with.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetId { get; set; }

        }

        public string Type { get; } = "AWS::EC2::SubnetCidrBlock";

        public SubnetCidrBlockProperties Properties { get; } = new SubnetCidrBlockProperties();

    }
}
