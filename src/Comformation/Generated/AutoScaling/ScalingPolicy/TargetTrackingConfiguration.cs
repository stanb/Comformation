using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.ScalingPolicy
{
    /// <summary>
    /// AWS::AutoScaling::ScalingPolicy TargetTrackingConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-targettrackingconfiguration.html
    /// </summary>
    public class TargetTrackingConfiguration
    {

        /// <summary>
        /// CustomizedMetricSpecification
        /// A customized metric. You must specify either a predefined metric or a customized metric.
        /// Required: Conditional
        /// Type: CustomizedMetricSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomizedMetricSpecification")]
        public CustomizedMetricSpecification CustomizedMetricSpecification { get; set; }

        /// <summary>
        /// DisableScaleIn
        /// Indicates whether scaling in by the target tracking scaling policy is disabled. If scaling in is
        /// disabled, the target tracking scaling policy doesn&#39;t remove instances from the Auto Scaling group.
        /// Otherwise, the target tracking scaling policy can remove instances from the Auto Scaling group. The
        /// default is false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DisableScaleIn")]
        public Union<bool, IntrinsicFunction> DisableScaleIn { get; set; }

        /// <summary>
        /// PredefinedMetricSpecification
        /// A predefined metric. You must specify either a predefined metric or a customized metric.
        /// Required: Conditional
        /// Type: PredefinedMetricSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredefinedMetricSpecification")]
        public PredefinedMetricSpecification PredefinedMetricSpecification { get; set; }

        /// <summary>
        /// TargetValue
        /// The target value for the metric.
        /// Required: Yes
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetValue")]
        public Union<double, IntrinsicFunction> TargetValue { get; set; }

    }
}
