using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel H265ColorSpaceSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265colorspacesettings.html
    /// </summary>
    public class H265ColorSpaceSettings
    {

        /// <summary>
        /// Rec601Settings
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Rec601Settings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Rec601Settings")]
        public Rec601Settings Rec601Settings { get; set; }

        /// <summary>
        /// Rec709Settings
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Rec709Settings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Rec709Settings")]
        public Rec709Settings Rec709Settings { get; set; }

        /// <summary>
        /// ColorSpacePassthroughSettings
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: ColorSpacePassthroughSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColorSpacePassthroughSettings")]
        public ColorSpacePassthroughSettings ColorSpacePassthroughSettings { get; set; }

        /// <summary>
        /// Hdr10Settings
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Hdr10Settings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Hdr10Settings")]
        public Hdr10Settings Hdr10Settings { get; set; }

    }
}
