using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Layer
{
    /// <summary>
    /// AWS::OpsWorks::Layer LoadBasedAutoScaling
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-layer-loadbasedautoscaling.html
    /// </summary>
    public class LoadBasedAutoScaling
    {

        /// <summary>
        /// DownScaling
        /// An AutoScalingThresholds object that describes the downscaling configuration, which defines how and
        /// when AWS OpsWorks Stacks reduces the number of instances.
        /// Required: No
        /// Type: AutoScalingThresholds
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DownScaling")]
        public AutoScalingThresholds DownScaling { get; set; }

        /// <summary>
        /// Enable
        /// Whether load-based auto scaling is enabled for the layer.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enable")]
        public Union<bool, IntrinsicFunction> Enable { get; set; }

        /// <summary>
        /// UpScaling
        /// An AutoScalingThresholds object that describes the upscaling configuration, which defines how and
        /// when AWS OpsWorks Stacks increases the number of instances.
        /// Required: No
        /// Type: AutoScalingThresholds
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UpScaling")]
        public AutoScalingThresholds UpScaling { get; set; }

    }
}
