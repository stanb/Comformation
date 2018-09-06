using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AmazonMQ.Broker
{
    /// <summary>
    /// Amazon MQ Broker MaintenanceWindow
    /// The MaintenanceWindow property type specifies the parameters that determine the WeeklyStartTime for an Amazon
    /// MQ broker.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amazonmq-broker-maintenancewindow.html
    /// </summary>
    public class MaintenanceWindow
    {

        /// <summary>
        /// DayOfWeek
        /// The day of the week, for example MONDAY, TUESDAY.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DayOfWeek")]
        public Union<string, IntrinsicFunction> DayOfWeek { get; set; }

        /// <summary>
        /// TimeOfDay
        /// The time, in 24-hour format.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("TimeOfDay")]
        public Union<string, IntrinsicFunction> TimeOfDay { get; set; }

        /// <summary>
        /// TimeZone
        /// The time zone, UTC by default, in either the Country/City format, or the UTC offset format.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("TimeZone")]
        public Union<string, IntrinsicFunction> TimeZone { get; set; }

    }
}
