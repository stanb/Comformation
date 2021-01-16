using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel Hdr10Settings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hdr10settings.html
    /// </summary>
    public class Hdr10Settings
    {

        /// <summary>
        /// MaxCll
        /// Maximum Content Light Level An integer metadata value defining the maximum light level, in nits, of
        /// any single pixel within an encoded HDR video stream or file.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxCll")]
        public Union<int, IntrinsicFunction> MaxCll { get; set; }

        /// <summary>
        /// MaxFall
        /// Maximum Frame Average Light Level An integer metadata value defining the maximum average light
        /// level, in nits, for any single frame within an encoded HDR video stream or file.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxFall")]
        public Union<int, IntrinsicFunction> MaxFall { get; set; }

    }
}
