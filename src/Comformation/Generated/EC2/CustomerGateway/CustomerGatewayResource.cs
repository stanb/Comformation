using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.CustomerGateway
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-customer-gateway.html
    /// </summary>
    public class CustomerGatewayResource : ResourceBase
    {
        public class CustomerGatewayProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-customer-gateway.html#cfn-ec2-customergateway-bgpasn
            /// </summary>
			public Union<int, IntrinsicFunction> BgpAsn { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-customer-gateway.html#cfn-ec2-customergateway-ipaddress
            /// </summary>
			public Union<string, IntrinsicFunction> IpAddress { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-customer-gateway.html#cfn-ec2-customergateway-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-customer-gateway.html#cfn-ec2-customergateway-type
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::CustomerGateway";
        
        public CustomerGatewayProperties Properties { get; } = new CustomerGatewayProperties();
    }
}
