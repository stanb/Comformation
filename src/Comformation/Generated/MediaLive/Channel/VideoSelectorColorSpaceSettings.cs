using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel VideoSelectorColorSpaceSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselectorcolorspacesettings.html
    /// </summary>
    public class VideoSelectorColorSpaceSettings
    {

        /// <summary>
        /// Hdr10Settings
        /// Settings to configure color space settings in the incoming video.
        /// Required: No
        /// Type: Hdr10Settings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Hdr10Settings")]
        public Hdr10Settings Hdr10Settings { get; set; }

    }
}
