using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel FailoverConditionSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-failoverconditionsettings.html
    /// </summary>
    public class FailoverConditionSettings
    {

        /// <summary>
        /// AudioSilenceSettings
        /// MediaLive will perform a failover if the specified audio selector is silent for the specified
        /// period.
        /// Required: No
        /// Type: AudioSilenceFailoverSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioSilenceSettings")]
        public AudioSilenceFailoverSettings AudioSilenceSettings { get; set; }

        /// <summary>
        /// VideoBlackSettings
        /// MediaLive will perform a failover if content is considered black for the specified period.
        /// Required: No
        /// Type: VideoBlackFailoverSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VideoBlackSettings")]
        public VideoBlackFailoverSettings VideoBlackSettings { get; set; }

        /// <summary>
        /// InputLossSettings
        /// MediaLive will perform a failover if content is not detected in this input for the specified period.
        /// Required: No
        /// Type: InputLossFailoverSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputLossSettings")]
        public InputLossFailoverSettings InputLossSettings { get; set; }

    }
}
