using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.CustomerGateway
{
    /// <summary>
    /// AWS::EC2::CustomerGateway
    /// Provides information to AWS about your VPN customer gateway device.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-customer-gateway.html
    /// </summary>
    public class CustomerGatewayResource : ResourceBase
    {
        public class CustomerGatewayProperties
        {
            /// <summary>
            /// BgpAsn
            /// The customer gateway's Border Gateway Protocol (BGP) Autonomous System Number (ASN).
            /// Required: Yes
            /// Type: Number BgpAsn is always an integer value.
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> BgpAsn { get; set; }

            /// <summary>
            /// IpAddress
            /// The internet-routable IP address for the customer gateway's outside interface. The address must be
            /// static.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> IpAddress { get; set; }

            /// <summary>
            /// Tags
            /// The tags that you want to attach to the resource.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags.
            /// Update requires: No interruption.
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// Type
            /// The type of VPN connection that this customer gateway supports.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// Example: ipsec. 1
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::CustomerGateway";
        
        public CustomerGatewayProperties Properties { get; } = new CustomerGatewayProperties();
    }
}
