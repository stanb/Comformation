using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkInsightsAnalysis
{
    /// <summary>
    /// AWS::EC2::NetworkInsightsAnalysis PathComponent
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html
    /// </summary>
    public class PathComponent
    {

        /// <summary>
        /// SequenceNumber
        /// The sequence number.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SequenceNumber")]
        public Union<int, IntrinsicFunction> SequenceNumber { get; set; }

        /// <summary>
        /// AclRule
        /// The network ACL rule.
        /// Required: No
        /// Type: AnalysisAclRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AclRule")]
        public AnalysisAclRule AclRule { get; set; }

        /// <summary>
        /// Component
        /// The component.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Component")]
        public AnalysisComponent Component { get; set; }

        /// <summary>
        /// DestinationVpc
        /// The destination VPC.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationVpc")]
        public AnalysisComponent DestinationVpc { get; set; }

        /// <summary>
        /// OutboundHeader
        /// The outbound header.
        /// Required: No
        /// Type: AnalysisPacketHeader
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutboundHeader")]
        public AnalysisPacketHeader OutboundHeader { get; set; }

        /// <summary>
        /// InboundHeader
        /// The inbound header.
        /// Required: No
        /// Type: AnalysisPacketHeader
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InboundHeader")]
        public AnalysisPacketHeader InboundHeader { get; set; }

        /// <summary>
        /// RouteTableRoute
        /// The route table route.
        /// Required: No
        /// Type: AnalysisRouteTableRoute
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RouteTableRoute")]
        public AnalysisRouteTableRoute RouteTableRoute { get; set; }

        /// <summary>
        /// SecurityGroupRule
        /// The security group rule.
        /// Required: No
        /// Type: AnalysisSecurityGroupRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupRule")]
        public AnalysisSecurityGroupRule SecurityGroupRule { get; set; }

        /// <summary>
        /// SourceVpc
        /// The source VPC.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceVpc")]
        public AnalysisComponent SourceVpc { get; set; }

        /// <summary>
        /// Subnet
        /// The subnet.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Subnet")]
        public AnalysisComponent Subnet { get; set; }

        /// <summary>
        /// Vpc
        /// The component VPC.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Vpc")]
        public AnalysisComponent Vpc { get; set; }

    }
}
