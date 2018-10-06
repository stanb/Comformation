using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Route
{
    /// <summary>
    /// AWS::EC2::Route
    /// The AWS::EC2::Route resource creates a new route in a route table within a VPC. The route&#39;s target can be
    /// either a gateway attached to the VPC or a NAT instance in the VPC.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-route.html
    /// </summary>
    public class RouteResource : ResourceBase
    {
        public class RouteProperties
        {
            /// <summary>
            /// DestinationCidrBlock
            /// The IPv4 CIDR address block used for the destination match. For example, 0. 0. 0. 0/0. Routing
            /// decisions are based on the most specific match.
            /// Required: Conditional. You must specify the DestinationCidrBlock or DestinationIpv6CidrBlock
            /// property.
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DestinationCidrBlock { get; set; }

            /// <summary>
            /// DestinationIpv6CidrBlock
            /// The IPv6 CIDR address block used for the destination match. For example, ::/0. Routing decisions are
            /// based on the most specific match.
            /// Required: Conditional. You must specify the DestinationCidrBlock or DestinationIpv6CidrBlock
            /// property.
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DestinationIpv6CidrBlock { get; set; }

            /// <summary>
            /// EgressOnlyInternetGatewayId
            /// The ID of an egress-only internet gateway that is attached to your VPC (over IPv6 only).
            /// Required: Conditional. You must specify only one of the following properties:
            /// EgressOnlyInternetGatewayId, GatewayId, InstanceId, NatGatewayId, NetworkInterfaceId, or
            /// VpcPeeringConnectionId. For an example that uses this property, see Amazon EC2 Route with
            /// Egress-Only Internet Gateway.
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EgressOnlyInternetGatewayId { get; set; }

            /// <summary>
            /// GatewayId
            /// The ID of an internet gateway or virtual private gateway that is attached to your VPC. For example:
            /// igw-eaad4883.
            /// For route entries that specify a gateway, you must specify a dependency on the gateway attachment
            /// resource. For more information, see DependsOn Attribute.
            /// Required: Conditional. You must specify only one of the following properties:
            /// EgressOnlyInternetGatewayId, GatewayId, InstanceId, NatGatewayId, NetworkInterfaceId, or
            /// VpcPeeringConnectionId.
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> GatewayId { get; set; }

            /// <summary>
            /// InstanceId
            /// The ID of a NAT instance in your VPC. For example, i-1a2b3c4d.
            /// Required: Conditional. You must specify only one of the following properties:
            /// EgressOnlyInternetGatewayId, GatewayId, InstanceId, NatGatewayId, NetworkInterfaceId, or
            /// VpcPeeringConnectionId.
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceId { get; set; }

            /// <summary>
            /// NatGatewayId
            /// The ID of a NAT gateway. For example, nat-0a12bc456789de0fg.
            /// Required: Conditional. You must specify only one of the following properties:
            /// EgressOnlyInternetGatewayId, GatewayId, InstanceId, NatGatewayId, NetworkInterfaceId, or
            /// VpcPeeringConnectionId.
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> NatGatewayId { get; set; }

            /// <summary>
            /// NetworkInterfaceId
            /// Allows the routing of network interface IDs.
            /// Required: Conditional. You must specify only one of the following properties:
            /// EgressOnlyInternetGatewayId, GatewayId, InstanceId, NatGatewayId, NetworkInterfaceId, or
            /// VpcPeeringConnectionId.
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> NetworkInterfaceId { get; set; }

            /// <summary>
            /// RouteTableId
            /// The ID of the route table where the route will be added.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> RouteTableId { get; set; }

            /// <summary>
            /// VpcPeeringConnectionId
            /// The ID of a VPC peering connection.
            /// Required: Conditional. You must specify only one of the following properties:
            /// EgressOnlyInternetGatewayId, GatewayId, InstanceId, NatGatewayId, NetworkInterfaceId, or
            /// VpcPeeringConnectionId.
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> VpcPeeringConnectionId { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::Route";
        
        public RouteProperties Properties { get; } = new RouteProperties();

    }
}
