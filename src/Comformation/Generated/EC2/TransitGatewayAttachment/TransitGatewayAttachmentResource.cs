using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.TransitGatewayAttachment
{
    /// <summary>
    /// AWS::EC2::TransitGatewayAttachment
    /// Creates an attachment between a VPC and a transit gateway. For more information, see Amazon VPC Transit
    /// Gateways.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayattachment.html
    /// </summary>
    public class TransitGatewayAttachmentResource : ResourceBase
    {
        public class TransitGatewayAttachmentProperties
        {
            /// <summary>
            /// TransitGatewayId
            /// The ID of the transit gateway.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> TransitGatewayId { get; set; }

            /// <summary>
            /// VpcId
            /// The ID of the VPC.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> VpcId { get; set; }

            /// <summary>
            /// SubnetIds
            /// The IDs of one or more subnets. You can specify only one subnet per Availability Zone. You must
            /// specify at least one subnet, but we recommend that you specify two subnets for better availability.
            /// The transit gateway uses one IP address from each specified subnet.
            /// Required: Yes
            /// Type: List of String values
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

            /// <summary>
            /// Tags
            /// The tags to apply to the VPC attachment.
            /// Required: No
            /// Type: List of Resource Tag property types
            /// Update requires: Replacement
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EC2::TransitGatewayAttachment";

        public TransitGatewayAttachmentProperties Properties { get; } = new TransitGatewayAttachmentProperties();

    }
}
