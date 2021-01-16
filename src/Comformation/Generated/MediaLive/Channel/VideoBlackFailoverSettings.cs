using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel VideoBlackFailoverSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoblackfailoversettings.html
    /// </summary>
    public class VideoBlackFailoverSettings
    {

        /// <summary>
        /// VideoBlackThresholdMsec
        /// The amount of time (in milliseconds) that the active input must be black before automatic input
        /// failover occurs.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VideoBlackThresholdMsec")]
        public Union<int, IntrinsicFunction> VideoBlackThresholdMsec { get; set; }

        /// <summary>
        /// BlackDetectThreshold
        /// A value used in calculating the threshold below which MediaLive considers a pixel to be &#39;black&#39;. For
        /// the input to be considered black, every pixel in a frame must be below this threshold. The threshold
        /// is calculated as a percentage (expressed as a decimal) of white. Therefore . 1 means 10% white (or
        /// 90% black). Note how the formula works for any color depth. For example, if you set this field to 0.
        /// 1 in 10-bit color depth: (1023*0. 1=102. 3), which means a pixel value of 102 or less is &#39;black&#39;. If
        /// you set this field to . 1 in an 8-bit color depth: (255*0. 1=25. 5), which means a pixel value of 25
        /// or less is &#39;black&#39;. The range is 0. 0 to 1. 0, with any number of decimal places.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlackDetectThreshold")]
        public Union<double, IntrinsicFunction> BlackDetectThreshold { get; set; }

    }
}
