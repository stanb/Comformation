using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LocalGatewayRouteTableVPCAssociation
{
    /// <summary>
    /// AWS::EC2::LocalGatewayRouteTableVPCAssociation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayroutetablevpcassociation.html
    /// </summary>
    public class LocalGatewayRouteTableVPCAssociationResource : ResourceBase
    {
        public class LocalGatewayRouteTableVPCAssociationProperties
        {
            /// <summary>
            /// LocalGatewayRouteTableId
            /// The ID of the local gateway route table.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> LocalGatewayRouteTableId { get; set; }

            /// <summary>
            /// VpcId
            /// The ID of the VPC.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> VpcId { get; set; }

            /// <summary>
            /// Tags
            /// 	
            /// The tags assigned to the association.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EC2::LocalGatewayRouteTableVPCAssociation";

        public LocalGatewayRouteTableVPCAssociationProperties Properties { get; } = new LocalGatewayRouteTableVPCAssociationProperties();

    }

    public static class LocalGatewayRouteTableVPCAssociationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LocalGatewayId = new ResourceAttribute<Union<string, IntrinsicFunction>>("LocalGatewayId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LocalGatewayRouteTableVpcAssociationId = new ResourceAttribute<Union<string, IntrinsicFunction>>("LocalGatewayRouteTableVpcAssociationId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> State = new ResourceAttribute<Union<string, IntrinsicFunction>>("State");
    }
}
