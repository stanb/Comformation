using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPCEndpointService
{
    /// <summary>
    /// AWS::EC2::VPCEndpointService
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointservice.html
    /// </summary>
    public class VPCEndpointServiceResource : ResourceBase
    {
        public class VPCEndpointServiceProperties
        {
            /// <summary>
            /// NetworkLoadBalancerArns
            /// 		
            /// The Amazon Resource Names (ARNs) of one or more Network Load Balancers for your service.
            /// 	
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> NetworkLoadBalancerArns { get; set; }

            /// <summary>
            /// AcceptanceRequired
            /// 		
            /// Indicates whether requests from service consumers to create an endpoint to your service 			must be
            /// accepted.
            /// 	
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AcceptanceRequired { get; set; }

            /// <summary>
            /// GatewayLoadBalancerArns
            /// The Amazon Resource Names (ARNs) of one or more Gateway Load Balancers.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> GatewayLoadBalancerArns { get; set; }

        }

        public string Type { get; } = "AWS::EC2::VPCEndpointService";

        public VPCEndpointServiceProperties Properties { get; } = new VPCEndpointServiceProperties();

    }
}
