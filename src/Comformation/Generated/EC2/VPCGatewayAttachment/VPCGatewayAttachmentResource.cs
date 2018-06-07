using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPCGatewayAttachment
{
    /// <summary>
    /// AWS::EC2::VPCGatewayAttachment
    /// Attaches a gateway to a VPC.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-gateway-attachment.html
    /// </summary>
    public class VPCGatewayAttachmentResource : ResourceBase
    {
        public class VPCGatewayAttachmentProperties
        {
            /// <summary>
            /// InternetGatewayId
            /// The ID of the Internet gateway.
            /// Required: Conditional You must specify either InternetGatewayId or VpnGatewayId, but not both.
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-gateway-attachment.html#cfn-ec2-vpcgatewayattachment-internetgatewayid
            /// </summary>
			public Union<string, IntrinsicFunction> InternetGatewayId { get; set; }

            /// <summary>
            /// VpcId
            /// The ID of the VPC to associate with this gateway.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-gateway-attachment.html#cfn-ec2-vpcgatewayattachment-vpcid
            /// </summary>
			public Union<string, IntrinsicFunction> VpcId { get; set; }

            /// <summary>
            /// VpnGatewayId
            /// The ID of the virtual private network (VPN) gateway to attach to the VPC.
            /// Required: Conditional You must specify either InternetGatewayId or VpnGatewayId, but not both.
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-gateway-attachment.html#cfn-ec2-vpcgatewayattachment-vpngatewayid
            /// </summary>
			public Union<string, IntrinsicFunction> VpnGatewayId { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::VPCGatewayAttachment";
        
        public VPCGatewayAttachmentProperties Properties { get; } = new VPCGatewayAttachmentProperties();
    }
}
