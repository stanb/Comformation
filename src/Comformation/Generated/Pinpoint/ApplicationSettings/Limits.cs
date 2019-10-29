using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.ApplicationSettings
{
    /// <summary>
    /// AWS::Pinpoint::ApplicationSettings Limits
    /// The default sending limits for campaigns in the application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-applicationsettings-limits.html
    /// </summary>
    public class Limits
    {

        /// <summary>
        /// Daily
        /// The maximum number of messages that a campaign can send to a single endpoint during a 24-hour
        /// period. The maximum value is 100.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Daily")]
        public Union<int, IntrinsicFunction> Daily { get; set; }

        /// <summary>
        /// MaximumDuration
        /// The maximum amount of time, in seconds, that a campaign can attempt to deliver a message after the
        /// scheduled start time for the campaign. The minimum value is 60 seconds.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaximumDuration")]
        public Union<int, IntrinsicFunction> MaximumDuration { get; set; }

        /// <summary>
        /// Total
        /// The maximum number of messages that a campaign can send to a single endpoint during the course of
        /// the campaign. The maximum value is 100.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Total")]
        public Union<int, IntrinsicFunction> Total { get; set; }

        /// <summary>
        /// MessagesPerSecond
        /// The maximum number of messages that a campaign can send each second. The minimum value is 50. The
        /// maximum value is 20,000.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MessagesPerSecond")]
        public Union<int, IntrinsicFunction> MessagesPerSecond { get; set; }

    }
}
