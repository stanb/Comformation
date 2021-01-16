using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel VideoSelectorSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselectorsettings.html
    /// </summary>
    public class VideoSelectorSettings
    {

        /// <summary>
        /// VideoSelectorProgramId
        /// Used to extract video by program ID.
        /// Required: No
        /// Type: VideoSelectorProgramId
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VideoSelectorProgramId")]
        public VideoSelectorProgramId VideoSelectorProgramId { get; set; }

        /// <summary>
        /// VideoSelectorPid
        /// Used to extract video by PID.
        /// Required: No
        /// Type: VideoSelectorPid
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VideoSelectorPid")]
        public VideoSelectorPid VideoSelectorPid { get; set; }

    }
}
