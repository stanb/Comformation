using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel TimecodeConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-timecodeconfig.html
    /// </summary>
    public class TimecodeConfig
    {

        /// <summary>
        /// SyncThreshold
        /// The threshold in frames beyond which output timecode is resynchronized to the input timecode.
        /// Discrepancies below this threshold are permitted to avoid unnecessary discontinuities in the output
        /// timecode. There is no timecode sync when this is not specified.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SyncThreshold")]
        public Union<int, IntrinsicFunction> SyncThreshold { get; set; }

        /// <summary>
        /// Source
        /// Identifies the source for the timecode that will be associated with the channel outputs. Embedded
        /// (embedded): Initialize the output timecode with timecode from the source. If no embedded timecode is
        /// detected in the source, the system falls back to using &quot;Start at 0&quot; (zerobased). System Clock
        /// (systemclock): Use the UTC time. Start at 0 (zerobased): The time of the first frame of the channel
        /// will be 00:00:00:00.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Source")]
        public Union<string, IntrinsicFunction> Source { get; set; }

    }
}
