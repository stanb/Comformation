using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Campaign
{
    /// <summary>
    /// AWS::Pinpoint::Campaign QuietTime
    /// Specifies the start and end times that define a time range when messages aren&#39;t sent to endpoints.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-schedule-quiettime.html
    /// </summary>
    public class QuietTime
    {

        /// <summary>
        /// Start
        /// The specific time when quiet time begins. This value has to use 24-hour notation and be in HH:MM
        /// format, where HH is the hour (with a leading zero, if applicable) and MM is the minutes. For
        /// example, use 02:30 to represent 2:30 AM, or 14:30 to represent 2:30 PM.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Start")]
        public Union<string, IntrinsicFunction> Start { get; set; }

        /// <summary>
        /// End
        /// The specific time when quiet time ends. This value has to use 24-hour notation and be in HH:MM
        /// format, where HH is the hour (with a leading zero, if applicable) and MM is the minutes. For
        /// example, use 02:30 to represent 2:30 AM, or 14:30 to represent 2:30 PM.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("End")]
        public Union<string, IntrinsicFunction> End { get; set; }

    }
}
