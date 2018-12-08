using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.TransitGatewayRouteTable
{
    /// <summary>
    /// AWS::EC2::TransitGatewayRouteTable
    /// Creates a route table for a transit gateway. For more information, see Amazon VPC Transit Gateways.
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
            /// The tags to apply to the transit gateway route table.
            /// Required: No
            /// Type: List of Resource Tag property types
            /// Update requires: Replacement
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EC2::TransitGatewayRouteTable";

        public TransitGatewayRouteTableProperties Properties { get; } = new TransitGatewayRouteTableProperties();

    }
}
