using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset DeltaTimeSessionWindowConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-deltatimesessionwindowconfiguration.html
    /// </summary>
    public class DeltaTimeSessionWindowConfiguration
    {

        /// <summary>
        /// TimeoutInMinutes
        /// A time interval. You can use timeoutInMinutes so that AWS IoT Analytics can batch up late data
        /// notifications that have been generated since the last execution. AWS IoT Analytics sends one batch
        /// of notifications to Amazon CloudWatch Events at one time.
        /// For more information about how to write a timestamp expression, see Date and Time Functions and
        /// Operators, in the Presto 0. 172 Documentation.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 60
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeoutInMinutes")]
        public Union<int, IntrinsicFunction> TimeoutInMinutes { get; set; }

    }
}
