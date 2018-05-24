using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SubnetCidrBlock
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnetcidrblock.html
    /// </summary>
    public class SubnetCidrBlockResource : ResourceBase
    {
        public class SubnetCidrBlockProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnetcidrblock.html#cfn-ec2-subnetcidrblock-ipv6cidrblock
            /// </summary>
			public Union<string, IntrinsicFunction> Ipv6CidrBlock { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnetcidrblock.html#cfn-ec2-subnetcidrblock-subnetid
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetId { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::SubnetCidrBlock";
        
        public SubnetCidrBlockProperties Properties { get; } = new SubnetCidrBlockProperties();
    }
}
