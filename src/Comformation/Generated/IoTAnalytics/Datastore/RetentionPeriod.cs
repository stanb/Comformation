using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Datastore
{
    /// <summary>
    /// AWS IoT Analytics Datastore RetentionPeriod
    /// The RetentionPeriod property type specifies how log, in days, message data is kept for an AWS IoT Analytics
    /// datastore.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-retentionperiod.html
    /// </summary>
    public class RetentionPeriod
    {

        /// <summary>
        /// NumberOfDays
        /// The number of days that message data is kept. The &quot;unlimited&quot; parameter must be false.
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
