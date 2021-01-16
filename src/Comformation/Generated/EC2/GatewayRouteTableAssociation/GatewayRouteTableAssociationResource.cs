using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.GatewayRouteTableAssociation
{
    /// <summary>
    /// AWS::EC2::GatewayRouteTableAssociation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-gatewayroutetableassociation.html
    /// </summary>
    public class GatewayRouteTableAssociationResource : ResourceBase
    {
        public class GatewayRouteTableAssociationProperties
        {
            /// <summary>
            /// RouteTableId
            /// The ID of the route table.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RouteTableId { get; set; }

            /// <summary>
            /// GatewayId
            /// The ID of the gateway.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> GatewayId { get; set; }

        }

        public string Type { get; } = "AWS::EC2::GatewayRouteTableAssociation";

        public GatewayRouteTableAssociationProperties Properties { get; } = new GatewayRouteTableAssociationProperties();

    }

    public static class GatewayRouteTableAssociationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AssociationId = new ResourceAttribute<Union<string, IntrinsicFunction>>("AssociationId");
    }
}
