using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EgressOnlyInternetGateway
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-egressonlyinternetgateway.html
    /// </summary>
    public class EgressOnlyInternetGatewayResource : ResourceBase
    {
        public class EgressOnlyInternetGatewayProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-egressonlyinternetgateway.html#cfn-ec2-egressonlyinternetgateway-vpcid
            /// </summary>
			public Union<string, IntrinsicFunction> VpcId { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::EgressOnlyInternetGateway";
        
        public EgressOnlyInternetGatewayProperties Properties { get; } = new EgressOnlyInternetGatewayProperties();
    }
}
