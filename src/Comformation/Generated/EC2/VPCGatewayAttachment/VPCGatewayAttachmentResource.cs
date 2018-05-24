using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPCGatewayAttachment
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-gateway-attachment.html
    /// </summary>
    public class VPCGatewayAttachmentResource : ResourceBase
    {
        public class VPCGatewayAttachmentProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-gateway-attachment.html#cfn-ec2-vpcgatewayattachment-internetgatewayid
            /// </summary>
			public Union<string, IntrinsicFunction> InternetGatewayId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-gateway-attachment.html#cfn-ec2-vpcgatewayattachment-vpcid
            /// </summary>
			public Union<string, IntrinsicFunction> VpcId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-gateway-attachment.html#cfn-ec2-vpcgatewayattachment-vpngatewayid
            /// </summary>
			public Union<string, IntrinsicFunction> VpnGatewayId { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::VPCGatewayAttachment";
        
        public VPCGatewayAttachmentProperties Properties { get; } = new VPCGatewayAttachmentProperties();
    }
}
