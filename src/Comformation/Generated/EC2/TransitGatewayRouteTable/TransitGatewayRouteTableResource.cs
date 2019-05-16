using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.TransitGatewayRouteTable
{
    /// <summary>
    /// AWS::EC2::TransitGatewayRouteTable
    /// Specifies a route table for a transit gateway.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroutetable.html
    /// </summary>
    public class TransitGatewayRouteTableResource : ResourceBase
    {
        public class TransitGatewayRouteTableProperties
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
            /// Tags
            /// Any tags assigned to the route table.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EC2::TransitGatewayRouteTable";

        public TransitGatewayRouteTableProperties Properties { get; } = new TransitGatewayRouteTableProperties();

    }
}
