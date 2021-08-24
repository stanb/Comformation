using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.MissionProfile
{
    /// <summary>
    /// AWS::GroundStation::MissionProfile DataflowEdge
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-missionprofile-dataflowedge.html
    /// </summary>
    public class DataflowEdge
    {

        /// <summary>
        /// Source
        /// The ARN of the source for this dataflow edge. For example, specify the ARN of an antenna downlink
        /// config for a downlink edge or a dataflow endpoint config for an uplink edge.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Source")]
        public Union<string, IntrinsicFunction> Source { get; set; }

        /// <summary>
        /// Destination
        /// The ARN of the destination for this dataflow edge. For example, specify the ARN of a dataflow
        /// endpoint config for a downlink edge or an antenna uplink config for an uplink edge.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destination")]
        public Union<string, IntrinsicFunction> Destination { get; set; }

    }
}
