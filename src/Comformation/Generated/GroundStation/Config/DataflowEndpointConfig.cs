using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.Config
{
    /// <summary>
    /// AWS::GroundStation::Config DataflowEndpointConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-dataflowendpointconfig.html
    /// </summary>
    public class DataflowEndpointConfig
    {

        /// <summary>
        /// DataflowEndpointName
        /// The name of the dataflow endpoint to use during contacts.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataflowEndpointName")]
        public Union<string, IntrinsicFunction> DataflowEndpointName { get; set; }

        /// <summary>
        /// DataflowEndpointRegion
        /// The region of the dataflow endpoint to use during contacts. When omitted, Ground Station will use
        /// the region of the contact.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataflowEndpointRegion")]
        public Union<string, IntrinsicFunction> DataflowEndpointRegion { get; set; }

    }
}
