using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.SecurityProfile
{
    /// <summary>
    /// AWS::IoT::SecurityProfile BehaviorCriteria
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-behaviorcriteria.html
    /// </summary>
    public class BehaviorCriteria
    {

        /// <summary>
        /// ComparisonOperator
        /// The operator that relates the thing measured (metric) to the criteria (containing a value or
        /// statisticalThreshold). Valid operators include:
        /// string-list: in-set and not-in-set number-list: in-set and not-in-set ip-address-list: in-cidr-set
        /// and not-in-cidr-set number: less-than, less-than-equals, greater-than, and greater-than-equals
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComparisonOperator")]
        public Union<string, IntrinsicFunction> ComparisonOperator { get; set; }

        /// <summary>
        /// Value
        /// The value to be compared with the metric.
        /// Required: No
        /// Type: MetricValue
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public MetricValue Value { get; set; }

        /// <summary>
        /// DurationSeconds
        /// Use this to specify the time duration over which the behavior is evaluated, for those criteria that
        /// have a time dimension (for example, NUM_MESSAGES_SENT). For a statisticalThreshhold metric
        /// comparison, measurements from all devices are accumulated over this time duration before being used
        /// to calculate percentiles, and later, measurements from an individual device are also accumulated
        /// over this time duration before being given a percentile rank. Cannot be used with list-based metric
        /// datatypes.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DurationSeconds")]
        public Union<int, IntrinsicFunction> DurationSeconds { get; set; }

        /// <summary>
        /// ConsecutiveDatapointsToAlarm
        /// If a device is in violation of the behavior for the specified number of consecutive datapoints, an
        /// alarm occurs. If not specified, the default is 1.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConsecutiveDatapointsToAlarm")]
        public Union<int, IntrinsicFunction> ConsecutiveDatapointsToAlarm { get; set; }

        /// <summary>
        /// ConsecutiveDatapointsToClear
        /// If an alarm has occurred and the offending device is no longer in violation of the behavior for the
        /// specified number of consecutive datapoints, the alarm is cleared. If not specified, the default is
        /// 1.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConsecutiveDatapointsToClear")]
        public Union<int, IntrinsicFunction> ConsecutiveDatapointsToClear { get; set; }

        /// <summary>
        /// StatisticalThreshold
        /// A statistical ranking (percentile)that indicates a threshold value by which a behavior is determined
        /// to be in compliance or in violation of the behavior.
        /// Required: No
        /// Type: StatisticalThreshold
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StatisticalThreshold")]
        public StatisticalThreshold StatisticalThreshold { get; set; }

        /// <summary>
        /// MlDetectionConfig
        /// The confidence level of the detection model.
        /// Required: No
        /// Type: MachineLearningDetectionConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MlDetectionConfig")]
        public MachineLearningDetectionConfig MlDetectionConfig { get; set; }

    }
}
