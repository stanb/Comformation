using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset RetentionPeriod
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-retentionperiod.html
    /// </summary>
    public class RetentionPeriod
    {

        /// <summary>
        /// NumberOfDays
        /// The number of days that message data is kept. The unlimited parameter must be false.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NumberOfDays")]
        public Union<int, IntrinsicFunction> NumberOfDays { get; set; }

        /// <summary>
        /// Unlimited
        /// If true, message data is kept indefinitely.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Unlimited")]
        public Union<bool, IntrinsicFunction> Unlimited { get; set; }

    }
}
