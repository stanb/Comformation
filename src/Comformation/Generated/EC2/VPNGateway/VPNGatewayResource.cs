using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPNGateway
{
    /// <summary>
    /// AWS::EC2::VPNGateway
    /// Creates a virtual private gateway. A virtual private gateway is the VPC-side endpoint for your VPN connection.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-gateway.html
    /// </summary>
    public class VPNGatewayResource : ResourceBase
    {
        public class VPNGatewayProperties
        {
            /// <summary>
            /// AmazonSideAsn
            /// The private Autonomous System Number (ASN) for the Amazon side of a BGP session.
            /// Required: No
            /// Type: Long
            /// Update requires: No interruption
            /// </summary>
			public Union<long, IntrinsicFunction> AmazonSideAsn { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this resource.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption.
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// Type
            /// The type of VPN connection this virtual private gateway supports. The only valid value is "ipsec.
            /// 1".
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::VPNGateway";
        
        public VPNGatewayProperties Properties { get; } = new VPNGatewayProperties();
    }
}
