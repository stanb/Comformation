using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.TransitGatewayRouteTablePropagation
{
    /// <summary>
    /// AWS::EC2::TransitGatewayRouteTablePropagation
    /// Enables an attachment to propagate routes. For more information, see Amazon VPC Transit Gateways.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroutetablepropagation.html
    /// </summary>
    public class TransitGatewayRouteTablePropagationResource : ResourceBase
    {
        public class TransitGatewayRouteTablePropagationProperties
        {
            /// <summary>
            /// TransitGatewayRouteTableId
            /// The ID of the propagation route table.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> TransitGatewayRouteTableId { get; set; }

            /// <summary>
            /// TransitGatewayAttachmentId
            /// The ID of the attachment.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> TransitGatewayAttachmentId { get; set; }

        }

        public string Type { get; } = "AWS::EC2::TransitGatewayRouteTablePropagation";

        public TransitGatewayRouteTablePropagationProperties Properties { get; } = new TransitGatewayRouteTablePropagationProperties();

    }
}
