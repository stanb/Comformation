using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.DataflowEndpointGroup
{
    /// <summary>
    /// AWS::GroundStation::DataflowEndpointGroup DataflowEndpoint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-dataflowendpoint.html
    /// </summary>
    public class DataflowEndpoint
    {

        /// <summary>
        /// Name
        /// The endpoint name.
        /// When listing available contacts for a satellite, Ground Station searches for a dataflow endpoint
        /// whose name matches the value specified by the dataflow endpoint config of the selected mission
        /// profile. If no matching dataflow endpoints are found then Ground Station will not display any
        /// available contacts for the satellite.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Address
        /// The address and port of an endpoint.
        /// Required: No
        /// Type: SocketAddress
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Address")]
        public SocketAddress Address { get; set; }

        /// <summary>
        /// Mtu
        /// Maximum transmission unit (MTU) size in bytes of a dataflow endpoint. Valid values are between 1400
        /// and 1500. A default value of 1500 is used if not set.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Mtu")]
        public Union<int, IntrinsicFunction> Mtu { get; set; }

    }
}
