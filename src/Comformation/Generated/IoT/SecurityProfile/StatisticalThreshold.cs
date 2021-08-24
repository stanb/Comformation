using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.SecurityProfile
{
    /// <summary>
    /// AWS::IoT::SecurityProfile StatisticalThreshold
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-statisticalthreshold.html
    /// </summary>
    public class StatisticalThreshold
    {

        /// <summary>
        /// Statistic
        /// The percentile that resolves to a threshold value by which compliance with a behavior is determined.
        /// Metrics are collected over the specified period (durationSeconds) from all reporting devices in your
        /// account and statistical ranks are calculated. Then, the measurements from a device are collected
        /// over the same period. If the accumulated measurements from the device fall above or below
        /// (comparisonOperator) the value associated with the percentile specified, then the device is
        /// considered to be in compliance with the behavior, otherwise a violation occurs.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Statistic")]
        public Union<string, IntrinsicFunction> Statistic { get; set; }

    }
}
