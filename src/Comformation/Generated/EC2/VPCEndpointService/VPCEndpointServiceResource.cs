using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPCEndpointService
{
    /// <summary>
    /// AWS::EC2::VPCEndpointService
    /// Specifies a VPC endpoint service configuration to which service consumers (AWS accounts, IAM users, and IAM
    /// roles) can connect. Service consumers can create an interface VPC endpoint to connect to your service.
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
            /// Required: Yes
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

        }

        public string Type { get; } = "AWS::EC2::VPCEndpointService";

        public VPCEndpointServiceProperties Properties { get; } = new VPCEndpointServiceProperties();

    }
}
