using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel DvbNitSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbnitsettings.html
    /// </summary>
    public class DvbNitSettings
    {

        /// <summary>
        /// NetworkName
        /// The network name text placed in the networkNameDescriptor inside the Network Information Table
        /// (NIT). The maximum length is 256 characters.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NetworkName")]
        public Union<string, IntrinsicFunction> NetworkName { get; set; }

        /// <summary>
        /// RepInterval
        /// The number of milliseconds between instances of this table in the output transport stream.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RepInterval")]
        public Union<int, IntrinsicFunction> RepInterval { get; set; }

        /// <summary>
        /// NetworkId
        /// The numeric value placed in the Network Information Table (NIT).
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NetworkId")]
        public Union<int, IntrinsicFunction> NetworkId { get; set; }

    }
}
