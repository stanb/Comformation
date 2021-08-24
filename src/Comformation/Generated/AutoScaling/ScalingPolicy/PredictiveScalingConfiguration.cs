using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.ScalingPolicy
{
    /// <summary>
    /// AWS::AutoScaling::ScalingPolicy PredictiveScalingConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingconfiguration.html
    /// </summary>
    public class PredictiveScalingConfiguration
    {

        /// <summary>
        /// MaxCapacityBreachBehavior
        /// Defines the behavior that should be applied if the forecast capacity approaches or exceeds the
        /// maximum capacity of the Auto Scaling group. Defaults to HonorMaxCapacity if not specified.
        /// The following are possible values:
        /// HonorMaxCapacity - Amazon EC2 Auto Scaling cannot scale out capacity higher than the maximum
        /// capacity. The maximum capacity is enforced as a hard limit. IncreaseMaxCapacity - Amazon EC2 Auto
        /// Scaling can scale out capacity higher than the maximum capacity when the forecast capacity is close
        /// to or exceeds the maximum capacity. The upper limit is determined by the forecasted capacity and the
        /// value for MaxCapacityBuffer.
        /// Required: No
        /// Type: String
        /// Allowed values: HonorMaxCapacity | IncreaseMaxCapacity
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxCapacityBreachBehavior")]
        public Union<string, IntrinsicFunction> MaxCapacityBreachBehavior { get; set; }

        /// <summary>
        /// MaxCapacityBuffer
        /// The size of the capacity buffer to use when the forecast capacity is close to or exceeds the maximum
        /// capacity. The value is specified as a percentage relative to the forecast capacity. For example, if
        /// the buffer is 10, this means a 10 percent buffer, such that if the forecast capacity is 50, and the
        /// maximum capacity is 40, then the effective maximum capacity is 55.
        /// If set to 0, Amazon EC2 Auto Scaling may scale capacity higher than the maximum capacity to equal
        /// but not exceed forecast capacity.
        /// Required if the MaxCapacityBreachBehavior property is set to IncreaseMaxCapacity, and cannot be used
        /// otherwise.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxCapacityBuffer")]
        public Union<int, IntrinsicFunction> MaxCapacityBuffer { get; set; }

        /// <summary>
        /// MetricSpecifications
        /// An array that contains information about the metrics and target utilization to use for predictive
        /// scaling.
        /// Note Adding more than one predictive scaling metric specification to the array is currently not
        /// supported.
        /// Required: Yes
        /// Type: List of PredictiveScalingMetricSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricSpecifications")]
        public List<PredictiveScalingMetricSpecification> MetricSpecifications { get; set; }

        /// <summary>
        /// Mode
        /// The predictive scaling mode. Defaults to ForecastOnly if not specified.
        /// Required: No
        /// Type: String
        /// Allowed values: ForecastAndScale | ForecastOnly
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Mode")]
        public Union<string, IntrinsicFunction> Mode { get; set; }

        /// <summary>
        /// SchedulingBufferTime
        /// The amount of time, in seconds, by which the instance launch time can be advanced. For example, the
        /// forecast says to add capacity at 10:00 AM, and you choose to pre-launch instances by 5 minutes. In
        /// that case, the instances will be launched at 9:55 AM. The intention is to give resources time to be
        /// provisioned. It can take a few minutes to launch an EC2 instance. The actual amount of time required
        /// depends on several factors, such as the size of the instance and whether there are startup scripts
        /// to complete.
        /// The value must be less than the forecast interval duration of 3600 seconds (60 minutes). Defaults to
        /// 300 seconds if not specified.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SchedulingBufferTime")]
        public Union<int, IntrinsicFunction> SchedulingBufferTime { get; set; }

    }
}
