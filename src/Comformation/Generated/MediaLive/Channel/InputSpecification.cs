using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel InputSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputspecification.html
    /// </summary>
    public class InputSpecification
    {

        /// <summary>
        /// Codec
        /// The codec to include in the input specification for this channel.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Codec")]
        public Union<string, IntrinsicFunction> Codec { get; set; }

        /// <summary>
        /// MaximumBitrate
        /// The maximum input bitrate for any input attached to this channel.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaximumBitrate")]
        public Union<string, IntrinsicFunction> MaximumBitrate { get; set; }

        /// <summary>
        /// Resolution
        /// The resolution for any input attached to this channel.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Resolution")]
        public Union<string, IntrinsicFunction> Resolution { get; set; }

    }
}
