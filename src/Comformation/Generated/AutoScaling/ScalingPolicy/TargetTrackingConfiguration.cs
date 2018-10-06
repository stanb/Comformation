using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.ScalingPolicy
{
    /// <summary>
    /// Amazon EC2 Auto Scaling ScalingPolicy TargetTrackingConfiguration
    /// The TargetTrackingConfiguration property configures a target tracking scaling policy.
    /// TargetTrackingConfiguration is a property of the AWS::AutoScaling::ScalingPolicy resource. For more
    /// information, see PutScalingPolicy in the Amazon EC2 Auto Scaling API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-targettrackingconfiguration.html
    /// </summary>
    public class TargetTrackingConfiguration
    {

        /// <summary>
        /// CustomizedMetricSpecification
        /// A customized metric.
        /// Required: No
        /// Type: Amazon EC2 Auto Scaling ScalingPolicy CustomizedMetricSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomizedMetricSpecification")]
        public CustomizedMetricSpecification CustomizedMetricSpecification { get; set; }

        /// <summary>
        /// DisableScaleIn
        /// Indicates whether to disable scale-in for the target tracking policy. If true, the target tracking
        /// policy will not scale in the Auto Scaling group. The default value is false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DisableScaleIn")]
        public Union<bool, IntrinsicFunction> DisableScaleIn { get; set; }

        /// <summary>
        /// PredefinedMetricSpecification
        /// A predefined metric.
        /// Required: No
        /// Type: Amazon EC2 Auto Scaling ScalingPolicy PredefinedMetricSpecification
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
