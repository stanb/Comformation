using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPCEndpoint
{
    /// <summary>
    /// AWS::EC2::VPCEndpoint
    /// The AWS::EC2::VPCEndpoint resource creates a VPC endpoint that you can use to establish a private connection
    /// between your VPC and another AWS service without requiring access over the Internet, a VPN connection, or AWS
    /// Direct Connect.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpoint.html
    /// </summary>
    public class VPCEndpointResource : ResourceBase
    {
        public class VPCEndpointProperties
        {
            /// <summary>
            /// PolicyDocument
            /// A policy to attach to the endpoint that controls access to the service. The policy must be valid
            /// JSON. The default policy allows full access to the AWS service. For more information, see
            /// Controlling Access to Services in the Amazon VPC User Guide.
            /// Required: No
            /// Type: JSON object
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PolicyDocument { get; set; }

            /// <summary>
            /// RouteTableIds
            /// One or more route table IDs that are used by the VPC to reach the endpoint.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> RouteTableIds { get; set; }

            /// <summary>
            /// ServiceName
            /// The AWS service to which you want to establish a connection. Specify the service name in the form of
            /// com. amazonaws. region. service.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceName { get; set; }

            /// <summary>
            /// VpcId
            /// The ID of the VPC in which the endpoint is used.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> VpcId { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::VPCEndpoint";
        
        public VPCEndpointProperties Properties { get; } = new VPCEndpointProperties();
    }
}
