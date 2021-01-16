using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkInsightsAnalysis
{
    /// <summary>
    /// AWS::EC2::NetworkInsightsAnalysis AnalysisRouteTableRoute
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html
    /// </summary>
    public class AnalysisRouteTableRoute
    {

        /// <summary>
        /// destinationCidr
        /// The destination IPv4 address, in CIDR notation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("destinationCidr")]
        public Union<string, IntrinsicFunction> destinationCidr { get; set; }

        /// <summary>
        /// destinationPrefixListId
        /// The prefix of the AWS service.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("destinationPrefixListId")]
        public Union<string, IntrinsicFunction> destinationPrefixListId { get; set; }

        /// <summary>
        /// egressOnlyInternetGatewayId
        /// The ID of an egress-only internet gateway.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("egressOnlyInternetGatewayId")]
        public Union<string, IntrinsicFunction> egressOnlyInternetGatewayId { get; set; }

        /// <summary>
        /// gatewayId
        /// The ID of the gateway, such as an internet gateway or virtual private gateway.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("gatewayId")]
        public Union<string, IntrinsicFunction> gatewayId { get; set; }

        /// <summary>
        /// instanceId
        /// The ID of the instance, such as a NAT instance.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("instanceId")]
        public Union<string, IntrinsicFunction> instanceId { get; set; }

        /// <summary>
        /// NatGatewayId
        /// The ID of a NAT gateway.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NatGatewayId")]
        public Union<string, IntrinsicFunction> NatGatewayId { get; set; }

        /// <summary>
        /// NetworkInterfaceId
        /// The ID of a network interface.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public Union<string, IntrinsicFunction> NetworkInterfaceId { get; set; }

        /// <summary>
        /// Origin
        /// Describes how the route was created. The following are possible values:
        /// CreateRouteTable - The route was automatically created when the route table was created. CreateRoute
        /// - The route was manually added to the route table. EnableVgwRoutePropagation - The route was
        /// propagated by route propagation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Origin")]
        public Union<string, IntrinsicFunction> Origin { get; set; }

        /// <summary>
        /// TransitGatewayId
        /// The ID of a transit gateway.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TransitGatewayId")]
        public Union<string, IntrinsicFunction> TransitGatewayId { get; set; }

        /// <summary>
        /// VpcPeeringConnectionId
        /// The ID of a VPC peering connection.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpcPeeringConnectionId")]
        public Union<string, IntrinsicFunction> VpcPeeringConnectionId { get; set; }

    }
}
