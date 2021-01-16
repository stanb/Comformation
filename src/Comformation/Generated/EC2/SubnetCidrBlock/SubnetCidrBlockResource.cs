using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SubnetCidrBlock
{
    /// <summary>
    /// AWS::EC2::SubnetCidrBlock
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnetcidrblock.html
    /// </summary>
    public class SubnetCidrBlockResource : ResourceBase
    {
        public class SubnetCidrBlockProperties
        {
            /// <summary>
            /// Ipv6CidrBlock
            /// The IPv6 network range for the subnet, in CIDR notation. The subnet size must use a /64 prefix
            /// length.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Ipv6CidrBlock { get; set; }

            /// <summary>
            /// SubnetId
            /// 	
            /// The ID of the subnet.
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
