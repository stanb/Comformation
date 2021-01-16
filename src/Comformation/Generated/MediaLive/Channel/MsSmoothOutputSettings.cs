using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel MsSmoothOutputSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothoutputsettings.html
    /// </summary>
    public class MsSmoothOutputSettings
    {

        /// <summary>
        /// NameModifier
        /// A string that is concatenated to the end of the destination file name. This is required for multiple
        /// outputs of the same type.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NameModifier")]
        public Union<string, IntrinsicFunction> NameModifier { get; set; }

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

    }
}
