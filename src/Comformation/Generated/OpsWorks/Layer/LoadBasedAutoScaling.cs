using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Layer
{
    /// <summary>
    /// AWS OpsWorks LoadBasedAutoScaling Type
    /// Describes the load-based automatic scaling configuration for an AWS::OpsWorks::Layer resource type. For more
    /// information, see SetLoadBasedAutoScaling in the AWS OpsWorks Stacks API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-layer-loadbasedautoscaling.html
    /// </summary>
    public class LoadBasedAutoScaling
    {

        /// <summary>
        /// DownScaling
        /// The threshold below which the instances are scaled down (stopped). If the load falls below this
        /// threshold for a specified amount of time, AWS OpsWorks stops a specified number of instances.
        /// Required: No
        /// Type: AWS OpsWorks AutoScalingThresholds Type
        /// </summary>
        [JsonProperty("DownScaling")]
        public AutoScalingThresholds DownScaling { get; set; }

        /// <summary>
        /// Enable
        /// Whether to enable automatic load-based scaling for the layer.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("Enable")]
        public Union<bool, IntrinsicFunction> Enable { get; set; }

        /// <summary>
        /// UpScaling
        /// The threshold above which the instances are scaled up (added). If the load exceeds this thresholds
        /// for a specified amount of time, AWS OpsWorks starts a specified number of instances.
        /// Required: No
        /// Type: AWS OpsWorks AutoScalingThresholds Type
        /// </summary>
        [JsonProperty("UpScaling")]
        public AutoScalingThresholds UpScaling { get; set; }

    }
}
