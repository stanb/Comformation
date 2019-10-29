using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel VideoSelectorPid
    /// Selects a specific PID from within a video source.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselectorpid.html
    /// </summary>
    public class VideoSelectorPid
    {

        /// <summary>
        /// Pid
        /// Selects a specific PID from within a video source.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Pid")]
        public Union<int, IntrinsicFunction> Pid { get; set; }

    }
}
