using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Layer
{
    /// <summary>
    /// AWS OpsWorks AutoScalingThresholds Type
    /// Describes the scaling thresholds for the AWS OpsWorks LoadBasedAutoScaling Type property. For more
    /// information, see AutoScalingThresholds in the AWS OpsWorks Stacks API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-layer-loadbasedautoscaling-autoscalingthresholds.html
    /// </summary>
    public class AutoScalingThresholds
    {

        /// <summary>
        /// CpuThreshold
        /// The percentage of CPU utilization that triggers the starting or stopping of instances (scaling).
        /// Required: No
        /// Type: Number
        /// </summary>
        [JsonProperty("CpuThreshold")]
        public Union<double, IntrinsicFunction> CpuThreshold { get; set; }

        /// <summary>
        /// IgnoreMetricsTime
        /// The amount of time (in minutes) after a scaling event occurs that AWS OpsWorks should ignore metrics
        /// and not start any additional scaling events.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("IgnoreMetricsTime")]
        public Union<int, IntrinsicFunction> IgnoreMetricsTime { get; set; }

        /// <summary>
        /// InstanceCount
        /// The number of instances to add or remove when the load exceeds a threshold.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("InstanceCount")]
        public Union<int, IntrinsicFunction> InstanceCount { get; set; }

        /// <summary>
        /// LoadThreshold
        /// The degree of system load that triggers the starting or stopping of instances (scaling). For more
        /// information about how load is computed, see Load (computing).
        /// Required: No
        /// Type: Number
        /// </summary>
        [JsonProperty("LoadThreshold")]
        public Union<double, IntrinsicFunction> LoadThreshold { get; set; }

        /// <summary>
        /// MemoryThreshold
        /// The percentage of memory consumption that triggers the starting or stopping of instances (scaling).
        /// Required: No
        /// Type: Number
        /// </summary>
        [JsonProperty("MemoryThreshold")]
        public Union<double, IntrinsicFunction> MemoryThreshold { get; set; }

        /// <summary>
        /// ThresholdsWaitTime
        /// The amount of time, in minutes, that the load must exceed a threshold before instances are added or
        /// removed.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("ThresholdsWaitTime")]
        public Union<int, IntrinsicFunction> ThresholdsWaitTime { get; set; }

    }
}
