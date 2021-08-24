using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel SetTimer
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-settimer.html
    /// </summary>
    public class SetTimer
    {

        /// <summary>
        /// DurationExpression
        /// The duration of the timer, in seconds. You can use a string expression that includes numbers,
        /// variables ($variable. &amp;lt;variable-name&amp;gt;), and input values ($input. &amp;lt;input-name&amp;gt;.
        /// &amp;lt;path-to-datum&amp;gt;) as the duration. The range of the duration is 1-31622400 seconds. To ensure
        /// accuracy, the minimum duration is 60 seconds. The evaluated result of the duration is rounded down
        /// to the nearest whole number.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DurationExpression")]
        public Union<string, IntrinsicFunction> DurationExpression { get; set; }

        /// <summary>
        /// Seconds
        /// The number of seconds until the timer expires. The minimum value is 60 seconds to ensure accuracy.
        /// The maximum value is 31622400 seconds.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 31622400
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Seconds")]
        public Union<int, IntrinsicFunction> Seconds { get; set; }

        /// <summary>
        /// TimerName
        /// The name of the timer.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimerName")]
        public Union<string, IntrinsicFunction> TimerName { get; set; }

    }
}
