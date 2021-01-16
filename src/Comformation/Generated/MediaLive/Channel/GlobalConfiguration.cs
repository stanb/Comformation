using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel GlobalConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-globalconfiguration.html
    /// </summary>
    public class GlobalConfiguration
    {

        /// <summary>
        /// InputEndAction
        /// Indicates the action to take when the current input completes (for example, end-of-file). When
        /// switchAndLoopInputs is configured, MediaLive restarts at the beginning of the first input. When
        /// &quot;none&quot; is configured, MediaLive transcodes either black, a solid color, or a user-specified slate
        /// images per the &quot;Input Loss Behavior&quot; configuration until the next input switch occurs (which is
        /// controlled through the Channel Schedule API).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputEndAction")]
        public Union<string, IntrinsicFunction> InputEndAction { get; set; }

        /// <summary>
        /// OutputTimingSource
        /// Indicates whether the rate of frames emitted by the Live encoder should be paced by its system clock
        /// (which optionally might be locked to another source through NTP) or should be locked to the clock of
        /// the source that is providing the input stream.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputTimingSource")]
        public Union<string, IntrinsicFunction> OutputTimingSource { get; set; }

        /// <summary>
        /// OutputLockingMode
        /// Indicates how MediaLive pipelines are synchronized. PIPELINELOCKING - MediaLive attempts to
        /// synchronize the output of each pipeline to the other. EPOCHLOCKING - MediaLive attempts to
        /// synchronize the output of each pipeline to the Unix epoch.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputLockingMode")]
        public Union<string, IntrinsicFunction> OutputLockingMode { get; set; }

        /// <summary>
        /// SupportLowFramerateInputs
        /// Adjusts the video input buffer for streams with very low video frame rates. This is commonly set to
        /// enabled for music channels with less than one video frame per second.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SupportLowFramerateInputs")]
        public Union<string, IntrinsicFunction> SupportLowFramerateInputs { get; set; }

        /// <summary>
        /// InitialAudioGain
        /// The value to set the initial audio gain for the channel.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InitialAudioGain")]
        public Union<int, IntrinsicFunction> InitialAudioGain { get; set; }

        /// <summary>
        /// InputLossBehavior
        /// The settings for system actions when the input is lost.
        /// Required: No
        /// Type: InputLossBehavior
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputLossBehavior")]
        public InputLossBehavior InputLossBehavior { get; set; }

    }
}
