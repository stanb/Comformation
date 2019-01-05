using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Channel
{
    /// <summary>
    /// AWS IoT Analytics Channel RetentionPeriod
    /// The RetentionPeriod property type specifies how long, in days, message data is kept for an AWS IoT Analytics
    /// channel.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-channel-retentionperiod.html
    /// </summary>
    public class RetentionPeriod
    {

        /// <summary>
        /// NumberOfDays
        /// The number of days that message data is kept.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NumberOfDays")]
        public Union<int, IntrinsicFunction> NumberOfDays { get; set; }

        /// <summary>
        /// Unlimited
        /// If true, message data is kept indefinitely.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Unlimited")]
        public Union<bool, IntrinsicFunction> Unlimited { get; set; }

    }
}
