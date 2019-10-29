using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPCGatewayAttachment
{
    /// <summary>
    /// AWS::EC2::VPCGatewayAttachment
    /// Attaches an internet gateway, or a virtual private gateway to a VPC, enabling connectivity between the
    /// internet and 			the VPC.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-gateway-attachment.html
    /// </summary>
    public class VPCGatewayAttachmentResource : ResourceBase
    {
        public class VPCGatewayAttachmentProperties
        {
            /// <summary>
            /// InternetGatewayId
            /// 		
            /// The ID of the internet gateway.
            /// You must specify either InternetGatewayId or VpnGatewayId, but not both.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> InternetGatewayId { get; set; }

            /// <summary>
            /// VpcId
            /// 		
            /// The ID of the VPC.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> VpcId { get; set; }

            /// <summary>
            /// VpnGatewayId
            /// The ID of the virtual private gateway.
            /// You must specify either InternetGatewayId or VpnGatewayId, but not both.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> VpnGatewayId { get; set; }

        }

        public string Type { get; } = "AWS::EC2::VPCGatewayAttachment";

        public VPCGatewayAttachmentProperties Properties { get; } = new VPCGatewayAttachmentProperties();

    }
}
