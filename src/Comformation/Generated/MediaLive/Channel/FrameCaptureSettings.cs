using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel FrameCaptureSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-framecapturesettings.html
    /// </summary>
    public class FrameCaptureSettings
    {

        /// <summary>
        /// CaptureInterval
        /// The frequency, in seconds, for capturing frames for inclusion in the output. For example, &quot;10&quot; means
        /// capture a frame every 10 seconds.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CaptureInterval")]
        public Union<int, IntrinsicFunction> CaptureInterval { get; set; }

        /// <summary>
        /// CaptureIntervalUnits
        /// Unit for the frame capture interval.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CaptureIntervalUnits")]
        public Union<string, IntrinsicFunction> CaptureIntervalUnits { get; set; }

    }
}
