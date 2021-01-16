using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EgressOnlyInternetGateway
{
    /// <summary>
    /// AWS::EC2::EgressOnlyInternetGateway
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-egressonlyinternetgateway.html
    /// </summary>
    public class EgressOnlyInternetGatewayResource : ResourceBase
    {
        public class EgressOnlyInternetGatewayProperties
        {
            /// <summary>
            /// VpcId
            /// The ID of the VPC for which to create the egress-only internet gateway.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> VpcId { get; set; }

        }

        public string Type { get; } = "AWS::EC2::EgressOnlyInternetGateway";

        public EgressOnlyInternetGatewayProperties Properties { get; } = new EgressOnlyInternetGatewayProperties();

    }
}
