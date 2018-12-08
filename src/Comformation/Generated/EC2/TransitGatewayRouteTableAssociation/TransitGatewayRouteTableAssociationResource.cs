using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.TransitGatewayRouteTableAssociation
{
    /// <summary>
    /// AWS::EC2::TransitGatewayRouteTableAssociation
    /// Associate an attachment with a transit gateway route table. For more information, see Amazon VPC Transit
    /// Gateways.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroutetableassociation.html
    /// </summary>
    public class TransitGatewayRouteTableAssociationResource : ResourceBase
    {
        public class TransitGatewayRouteTableAssociationProperties
        {
            /// <summary>
            /// TransitGatewayRouteTableId
            /// The ID of the transit gateway route table.
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

        public string Type { get; } = "AWS::EC2::TransitGatewayRouteTableAssociation";

        public TransitGatewayRouteTableAssociationProperties Properties { get; } = new TransitGatewayRouteTableAssociationProperties();

    }
}
