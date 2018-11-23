using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScalingPlans.ScalingPlan
{
    /// <summary>
    /// AWS Auto Scaling ScalingPlan ScalingInstruction
    /// The ScalingInstruction property type specifies the scaling configuration for a scalable resource in an AWS
    /// Auto Scaling scaling plan.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html
    /// </summary>
    public class ScalingInstruction
    {

        /// <summary>
        /// DisableDynamicScaling
        /// Controls whether dynamic scaling by AWS Auto Scaling is disabled. When dynamic scaling is enabled,
        /// AWS Auto Scaling creates target tracking scaling policies based on the specified target tracking
        /// configurations.
        /// The default is enabled (false).
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DisableDynamicScaling")]
        public Union<bool, IntrinsicFunction> DisableDynamicScaling { get; set; }

        /// <summary>
        /// ServiceNamespace
        /// The namespace of the AWS service. For a list of values, see ScalingInstruction in the AWS Auto
        /// Scaling API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceNamespace")]
        public Union<string, IntrinsicFunction> ServiceNamespace { get; set; }

        /// <summary>
        /// PredictiveScalingMaxCapacityBehavior
        /// Defines the behavior that should be applied if the forecast capacity approaches or exceeds the
        /// maximum capacity specified for the resource. The default value is SetForecastCapacityToMaxCapacity.
        /// The following are possible values:
        /// SetForecastCapacityToMaxCapacity - AWS Auto Scaling cannot scale resource capacity higher than the
        /// maximum capacity. The maximum capacity is enforced as a hard limit. SetMaxCapacityToForecastCapacity
        /// - AWS Auto Scaling may scale resource capacity higher than the maximum capacity to equal but not
        /// exceed forecast capacity. SetMaxCapacityAboveForecastCapacity - AWS Auto Scaling may scale resource
        /// capacity higher than the maximum capacity by a specified buffer value. The intention is to give the
        /// target tracking scaling policy extra capacity if unexpected traffic occurs.
        /// Only valid when configuring predictive scaling.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredictiveScalingMaxCapacityBehavior")]
        public Union<string, IntrinsicFunction> PredictiveScalingMaxCapacityBehavior { get; set; }

        /// <summary>
        /// ScalableDimension
        /// The scalable dimension associated with the resource. For a list of values, see ScalingInstruction in
        /// the AWS Auto Scaling API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScalableDimension")]
        public Union<string, IntrinsicFunction> ScalableDimension { get; set; }

        /// <summary>
        /// ScalingPolicyUpdateBehavior
        /// Controls whether a resource&#39;s externally created scaling policies are kept or replaced.
        /// The default value is KeepExternalPolicies. If the parameter is set to ReplaceExternalPolicies, any
        /// scaling policies that are external to AWS Auto Scaling are deleted and new target tracking scaling
        /// policies created.
        /// Only valid when configuring dynamic scaling.
        /// Condition: The number of existing policies to be replaced must be less than or equal to 50. If there
        /// are more than 50 policies to be replaced, AWS Auto Scaling keeps all existing policies and does not
        /// create new ones.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScalingPolicyUpdateBehavior")]
        public Union<string, IntrinsicFunction> ScalingPolicyUpdateBehavior { get; set; }

        /// <summary>
        /// MinCapacity
        /// The minimum capacity of the resource.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinCapacity")]
        public Union<int, IntrinsicFunction> MinCapacity { get; set; }

        /// <summary>
        /// TargetTrackingConfigurations
        /// The structure that defines new target tracking configurations (up to 10). Each of these structures
        /// includes a specific scaling metric and a target value for the metric, along with various parameters
        /// to use with dynamic scaling.
        /// With predictive scaling and dynamic scaling, the resource scales based on the target tracking
        /// configuration that provides the largest capacity for both scale in and scale out.
        /// Condition: The scaling metric must be unique across target tracking configurations.
        /// Required: Yes
        /// Type: List of TargetTrackingConfiguration property types
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetTrackingConfigurations")]
        public List<TargetTrackingConfiguration> TargetTrackingConfigurations { get; set; }

        /// <summary>
        /// PredictiveScalingMaxCapacityBuffer
        /// The size of the capacity buffer to use when the forecast capacity is close to or exceeds the maximum
        /// capacity. The value is specified as a percentage relative to the forecast capacity. For example, if
        /// the buffer is 10, this means a 10 percent buffer, such that if the forecast capacity is 50, and the
        /// maximum capacity is 40, then the effective maximum capacity is 55.
        /// Only valid when configuring predictive scaling. Required if the PredictiveScalingMaxCapacityBehavior
        /// is set to SetMaxCapacityAboveForecastCapacity, and cannot be used otherwise.
        /// The range is 1-100.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredictiveScalingMaxCapacityBuffer")]
        public Union<int, IntrinsicFunction> PredictiveScalingMaxCapacityBuffer { get; set; }

        /// <summary>
        /// CustomizedLoadMetricSpecification
        /// The customized load metric to use for predictive scaling. This parameter or a
        /// PredefinedLoadMetricSpecification is required when configuring predictive scaling, and cannot be
        /// used otherwise.
        /// Required: No
        /// Type: CustomizedLoadMetricSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomizedLoadMetricSpecification")]
        public CustomizedLoadMetricSpecification CustomizedLoadMetricSpecification { get; set; }

        /// <summary>
        /// PredefinedLoadMetricSpecification
        /// The predefined load metric to use for predictive scaling. This parameter or a
        /// CustomizedLoadMetricSpecification is required when configuring predictive scaling, and cannot be
        /// used otherwise.
        /// Required: No
        /// Type: PredefinedLoadMetricSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredefinedLoadMetricSpecification")]
        public PredefinedLoadMetricSpecification PredefinedLoadMetricSpecification { get; set; }

        /// <summary>
        /// ResourceId
        /// The ID of the resource. For examples, see ScalingInstruction in the AWS Auto Scaling API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceId")]
        public Union<string, IntrinsicFunction> ResourceId { get; set; }

        /// <summary>
        /// ScheduledActionBufferTime
        /// The amount of time, in seconds, to buffer the run time of scheduled scaling actions when scaling
        /// out. For example, if the forecast says to add capacity at 10:00 AM, and the buffer time is 5
        /// minutes, then the run time of the corresponding scheduled scaling action will be 9:55 AM. The
        /// intention is to give resources time to be provisioned. For example, it can take a few minutes to
        /// launch an EC2 instance. The actual amount of time required depends on several factors, such as the
        /// size of the instance and whether there are startup scripts to complete.
        /// The value must be less than forecast interval duration of 3600 seconds (60 minutes). The default is
        /// 300 seconds.
        /// Only valid when configuring predictive scaling.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScheduledActionBufferTime")]
        public Union<int, IntrinsicFunction> ScheduledActionBufferTime { get; set; }

        /// <summary>
        /// MaxCapacity
        /// The maximum capacity of the resource. The exception to this upper limit is if you specify a
        /// non-default setting for PredictiveScalingMaxCapacityBehavior.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxCapacity")]
        public Union<int, IntrinsicFunction> MaxCapacity { get; set; }

        /// <summary>
        /// PredictiveScalingMode
        /// The predictive scaling mode. The default value is ForecastAndScale. Otherwise, AWS Auto Scaling
        /// forecasts capacity but does not create any scheduled scaling actions based on the capacity forecast.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredictiveScalingMode")]
        public Union<string, IntrinsicFunction> PredictiveScalingMode { get; set; }

    }
}
