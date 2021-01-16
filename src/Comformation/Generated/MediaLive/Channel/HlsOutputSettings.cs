using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel HlsOutputSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsoutputsettings.html
    /// </summary>
    public class HlsOutputSettings
    {

        /// <summary>
        /// NameModifier
        /// A string that is concatenated to the end of the destination file name. Accepts \&quot;Format
        /// Identifiers\&quot;:#formatIdentifierParameters.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NameModifier")]
        public Union<string, IntrinsicFunction> NameModifier { get; set; }

        /// <summary>
        /// HlsSettings
        /// The settings regarding the underlying stream. These settings are different for audio-only outputs.
        /// Required: No
        /// Type: HlsSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HlsSettings")]
        public HlsSettings HlsSettings { get; set; }

        /// <summary>
        /// H265PackagingType
        /// Only applicable when this output is referencing an H. 265 video description. Specifies whether MP4
        /// segments should be packaged as HEV1 or HVC1.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("H265PackagingType")]
        public Union<string, IntrinsicFunction> H265PackagingType { get; set; }

        /// <summary>
        /// SegmentModifier
        /// A string that is concatenated to the end of segment file names.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SegmentModifier")]
        public Union<string, IntrinsicFunction> SegmentModifier { get; set; }

    }
}
