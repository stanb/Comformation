using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkInsightsAnalysis
{
    /// <summary>
    /// AWS::EC2::NetworkInsightsAnalysis AnalysisPacketHeader
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysispacketheader.html
    /// </summary>
    public class AnalysisPacketHeader
    {

        /// <summary>
        /// DestinationAddresses
        /// The destination addresses.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationAddresses")]
        public List<Union<string, IntrinsicFunction>> DestinationAddresses { get; set; }

        /// <summary>
        /// DestinationPortRanges
        /// The destination port ranges.
        /// Required: No
        /// Type: List of PortRange
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationPortRanges")]
        public List<PortRange> DestinationPortRanges { get; set; }

        /// <summary>
        /// Protocol
        /// The protocol.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

        /// <summary>
        /// SourceAddresses
        /// The source addresses.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceAddresses")]
        public List<Union<string, IntrinsicFunction>> SourceAddresses { get; set; }

        /// <summary>
        /// SourcePortRanges
        /// The source port ranges.
        /// Required: No
        /// Type: List of PortRange
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourcePortRanges")]
        public List<PortRange> SourcePortRanges { get; set; }

    }
}
