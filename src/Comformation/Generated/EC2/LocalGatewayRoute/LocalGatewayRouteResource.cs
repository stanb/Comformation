using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LocalGatewayRoute
{
    /// <summary>
    /// AWS::EC2::LocalGatewayRoute
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayroute.html
    /// </summary>
    public class LocalGatewayRouteResource : ResourceBase
    {
        public class LocalGatewayRouteProperties
        {
            /// <summary>
            /// DestinationCidrBlock
            /// The CIDR block used for destination matches.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DestinationCidrBlock { get; set; }

            /// <summary>
            /// LocalGatewayRouteTableId
            /// The ID of the local gateway route table.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> LocalGatewayRouteTableId { get; set; }

            /// <summary>
            /// LocalGatewayVirtualInterfaceGroupId
            /// The ID of the virtual interface group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> LocalGatewayVirtualInterfaceGroupId { get; set; }

        }

        public string Type { get; } = "AWS::EC2::LocalGatewayRoute";

        public LocalGatewayRouteProperties Properties { get; } = new LocalGatewayRouteProperties();

    }

    public static class LocalGatewayRouteAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> State = new ResourceAttribute<Union<string, IntrinsicFunction>>("State");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Type = new ResourceAttribute<Union<string, IntrinsicFunction>>("Type");
    }
}
