using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Route
{
    /// <summary>
    /// AWS::EC2::Route
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-route.html
    /// </summary>
    public class RouteResource : ResourceBase
    {
        public class RouteProperties
        {
            /// <summary>
            /// CarrierGatewayId
            /// The ID of the carrier gateway.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CarrierGatewayId { get; set; }

            /// <summary>
            /// DestinationCidrBlock
            /// 		
            /// The IPv4 CIDR block used for the destination match.
            /// You must specify the DestinationCidrBlock or DestinationIpv6CidrBlock property.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DestinationCidrBlock { get; set; }

            /// <summary>
            /// DestinationIpv6CidrBlock
            /// The IPv6 CIDR block used for the destination match.
            /// You must specify the DestinationCidrBlock or DestinationIpv6CidrBlock property.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DestinationIpv6CidrBlock { get; set; }

            /// <summary>
            /// EgressOnlyInternetGatewayId
            /// The ID of the egress-only internet gateway.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EgressOnlyInternetGatewayId { get; set; }

            /// <summary>
            /// GatewayId
            /// 		
            /// The ID of an internet gateway or virtual private gateway attached to your VPC.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> GatewayId { get; set; }

            /// <summary>
            /// InstanceId
            /// 		
            /// The ID of a NAT instance in your VPC.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> InstanceId { get; set; }

            /// <summary>
            /// LocalGatewayId
            /// The ID of the local gateway.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> LocalGatewayId { get; set; }

            /// <summary>
            /// NatGatewayId
            /// The ID of a NAT gateway.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> NatGatewayId { get; set; }

            /// <summary>
            /// NetworkInterfaceId
            /// 		
            /// The ID of the network interface.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> NetworkInterfaceId { get; set; }

            /// <summary>
            /// RouteTableId
            /// The ID of the route table. The routing table must be associated with the same VPC that the virtual
            /// private gateway is attached to.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RouteTableId { get; set; }

            /// <summary>
            /// TransitGatewayId
            /// The ID of a transit gateway.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TransitGatewayId { get; set; }

            /// <summary>
            /// VpcEndpointId
            /// The ID of a VPC endpoint. Supported for Gateway Load Balancer endpoints only.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> VpcEndpointId { get; set; }

            /// <summary>
            /// VpcPeeringConnectionId
            /// The ID of a VPC peering connection.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> VpcPeeringConnectionId { get; set; }

        }

        public string Type { get; } = "AWS::EC2::Route";

        public RouteProperties Properties { get; } = new RouteProperties();

    }
}
