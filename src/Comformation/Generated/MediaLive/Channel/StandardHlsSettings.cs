using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel StandardHlsSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-standardhlssettings.html
    /// </summary>
    public class StandardHlsSettings
    {

        /// <summary>
        /// AudioRenditionSets
        /// Lists all the audio groups that are used with the video output stream. This inputs all the audio
        /// GROUP-IDs that are associated with the video, separated by a comma (,).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioRenditionSets")]
        public Union<string, IntrinsicFunction> AudioRenditionSets { get; set; }

        /// <summary>
        /// M3u8Settings
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: M3u8Settings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("M3u8Settings")]
        public M3u8Settings M3u8Settings { get; set; }

    }
}
