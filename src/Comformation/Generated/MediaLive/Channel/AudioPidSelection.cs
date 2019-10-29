using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel AudioPidSelection
    /// Used to extract audio by The PID.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiopidselection.html
    /// </summary>
    public class AudioPidSelection
    {

        /// <summary>
        /// Pid
        /// Select the audio by this PID.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Pid")]
        public Union<int, IntrinsicFunction> Pid { get; set; }

    }
}
