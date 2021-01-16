using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.TransitGatewayRoute
{
    /// <summary>
    /// AWS::EC2::TransitGatewayRoute
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroute.html
    /// </summary>
    public class TransitGatewayRouteResource : ResourceBase
    {
        public class TransitGatewayRouteProperties
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
            /// DestinationCidrBlock
            /// The CIDR block used for destination matches.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DestinationCidrBlock { get; set; }

            /// <summary>
            /// Blackhole
            /// Indicates whether to drop traffic that matches this route.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> Blackhole { get; set; }

            /// <summary>
            /// TransitGatewayAttachmentId
            /// The ID of the attachment.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TransitGatewayAttachmentId { get; set; }

        }

        public string Type { get; } = "AWS::EC2::TransitGatewayRoute";

        public TransitGatewayRouteProperties Properties { get; } = new TransitGatewayRouteProperties();

    }
}
