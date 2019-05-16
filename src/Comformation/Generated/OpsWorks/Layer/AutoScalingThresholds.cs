using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Layer
{
    /// <summary>
    /// AWS::OpsWorks::Layer AutoScalingThresholds
    /// Describes a load-based auto scaling upscaling or downscaling threshold configuration, which specifies when AWS
    /// OpsWorks Stacks starts or stops load-based instances.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-layer-loadbasedautoscaling-autoscalingthresholds.html
    /// </summary>
    public class AutoScalingThresholds
    {

        /// <summary>
        /// CpuThreshold
        /// The CPU utilization threshold, as a percent of the available CPU. A value of -1 disables the
        /// threshold.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CpuThreshold")]
        public Union<double, IntrinsicFunction> CpuThreshold { get; set; }

        /// <summary>
        /// IgnoreMetricsTime
        /// The amount of time (in minutes) after a scaling event occurs that AWS OpsWorks Stacks should ignore
        /// metrics and suppress additional scaling events. For example, AWS OpsWorks Stacks adds new instances
        /// following an upscaling event but the instances won&#39;t start reducing the load until they have been
        /// booted and configured. There is no point in raising additional scaling events during that operation,
        /// which typically takes several minutes. IgnoreMetricsTime allows you to direct AWS OpsWorks Stacks to
        /// suppress scaling events long enough to get the new instances online.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IgnoreMetricsTime")]
        public Union<int, IntrinsicFunction> IgnoreMetricsTime { get; set; }

        /// <summary>
        /// InstanceCount
        /// The number of instances to add or remove when the load exceeds a threshold.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceCount")]
        public Union<int, IntrinsicFunction> InstanceCount { get; set; }

        /// <summary>
        /// LoadThreshold
        /// The load threshold. A value of -1 disables the threshold. For more information about how load is
        /// computed, see Load (computing).
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LoadThreshold")]
        public Union<double, IntrinsicFunction> LoadThreshold { get; set; }

        /// <summary>
        /// MemoryThreshold
        /// The memory utilization threshold, as a percent of the available memory. A value of -1 disables the
        /// threshold.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MemoryThreshold")]
        public Union<double, IntrinsicFunction> MemoryThreshold { get; set; }

        /// <summary>
        /// ThresholdsWaitTime
        /// The amount of time, in minutes, that the load must exceed a threshold before more instances are
        /// added or removed.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ThresholdsWaitTime")]
        public Union<int, IntrinsicFunction> ThresholdsWaitTime { get; set; }

    }
}
