using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScalingPlans.ScalingPlan
{
    /// <summary>
    /// AWS::AutoScalingPlans::ScalingPlan ScalingInstruction
    /// ScalingInstruction is a property of ScalingPlan that specifies the scaling instruction for a scalable resource
    /// in a scaling plan. Each scaling instruction applies to one resource.
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
        /// The namespace of the AWS service.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: autoscaling | dynamodb | ec2 | ecs | rds
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
        /// - AWS Auto Scaling can scale resource capacity higher than the maximum capacity to equal but not
        /// exceed forecast capacity. SetMaxCapacityAboveForecastCapacity - AWS Auto Scaling can scale resource
        /// capacity higher than the maximum capacity by a specified buffer value. The intention is to give the
        /// target tracking scaling policy extra capacity if unexpected traffic occurs.
        /// Valid only when configuring predictive scaling.
        /// Required: No
        /// Type: String
        /// Allowed Values: SetForecastCapacityToMaxCapacity | SetMaxCapacityAboveForecastCapacity |
        /// SetMaxCapacityToForecastCapacity
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredictiveScalingMaxCapacityBehavior")]
        public Union<string, IntrinsicFunction> PredictiveScalingMaxCapacityBehavior { get; set; }

        /// <summary>
        /// ScalableDimension
        /// The scalable dimension associated with the resource.
        /// autoscaling:autoScalingGroup:DesiredCapacity - The desired capacity of an Auto Scaling group.
        /// ecs:service:DesiredCount - The desired task count of an ECS service.
        /// ec2:spot-fleet-request:TargetCapacity - The target capacity of a Spot Fleet request.
        /// dynamodb:table:ReadCapacityUnits - The provisioned read capacity for a DynamoDB table.
        /// dynamodb:table:WriteCapacityUnits - The provisioned write capacity for a DynamoDB table.
        /// dynamodb:index:ReadCapacityUnits - The provisioned read capacity for a DynamoDB global secondary
        /// index. dynamodb:index:WriteCapacityUnits - The provisioned write capacity for a DynamoDB global
        /// secondary index. rds:cluster:ReadReplicaCount - The count of Aurora Replicas in an Aurora DB
        /// cluster. Available for Aurora MySQL-compatible edition and Aurora PostgreSQL-compatible edition.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: autoscaling:autoScalingGroup:DesiredCapacity | dynamodb:index:ReadCapacityUnits |
        /// dynamodb:index:WriteCapacityUnits | dynamodb:table:ReadCapacityUnits |
        /// dynamodb:table:WriteCapacityUnits | ec2:spot-fleet-request:TargetCapacity | ecs:service:DesiredCount
        /// | rds:cluster:ReadReplicaCount
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScalableDimension")]
        public Union<string, IntrinsicFunction> ScalableDimension { get; set; }

        /// <summary>
        /// ScalingPolicyUpdateBehavior
        /// Controls whether your scaling policies that are external to AWS Auto Scaling are deleted and new
        /// target tracking scaling policies created. The default value is KeepExternalPolicies.
        /// Valid only when configuring dynamic scaling.
        /// Required: No
        /// Type: String
        /// Allowed Values: KeepExternalPolicies | ReplaceExternalPolicies
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
        /// The target tracking configurations (up to 10). Each of these structures must specify a unique
        /// scaling metric and a target value for the metric.
        /// Required: Yes
        /// Type: List of TargetTrackingConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetTrackingConfigurations")]
        public List<TargetTrackingConfiguration> TargetTrackingConfigurations { get; set; }

        /// <summary>
        /// PredictiveScalingMaxCapacityBuffer
        /// The size of the capacity buffer to use when the forecast capacity is close to or exceeds the maximum
        /// capacity. The value is specified as a percentage relative to the forecast capacity. For example, if
        /// the buffer is 10, this means a 10 percent buffer. With a 10 percent buffer, if the forecast capacity
        /// is 50, and the maximum capacity is 40, then the effective maximum capacity is 55.
        /// Valid only when configuring predictive scaling. Required if PredictiveScalingMaxCapacityBehavior is
        /// set to SetMaxCapacityAboveForecastCapacity, and cannot be used otherwise.
        /// The range is 1-100.
        /// Required: Conditional
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredictiveScalingMaxCapacityBuffer")]
        public Union<int, IntrinsicFunction> PredictiveScalingMaxCapacityBuffer { get; set; }

        /// <summary>
        /// CustomizedLoadMetricSpecification
        /// The customized load metric to use for predictive scaling. This property or a
        /// PredefinedLoadMetricSpecification is required when configuring predictive scaling, and cannot be
        /// used otherwise.
        /// Required: Conditional
        /// Type: CustomizedLoadMetricSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomizedLoadMetricSpecification")]
        public CustomizedLoadMetricSpecification CustomizedLoadMetricSpecification { get; set; }

        /// <summary>
        /// PredefinedLoadMetricSpecification
        /// The predefined load metric to use for predictive scaling. This property or a
        /// CustomizedLoadMetricSpecification is required when configuring predictive scaling, and cannot be
        /// used otherwise.
        /// Required: Conditional
        /// Type: PredefinedLoadMetricSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredefinedLoadMetricSpecification")]
        public PredefinedLoadMetricSpecification PredefinedLoadMetricSpecification { get; set; }

        /// <summary>
        /// ResourceId
        /// The ID of the resource. This string consists of the resource type and unique identifier.
        /// Auto Scaling group - The resource type is autoScalingGroup and the unique identifier is the name of
        /// the Auto Scaling group. Example: autoScalingGroup/my-asg. ECS service - The resource type is service
        /// and the unique identifier is the cluster name and service name. Example:
        /// service/default/sample-webapp. Spot Fleet request - The resource type is spot-fleet-request and the
        /// unique identifier is the Spot Fleet request ID. Example:
        /// spot-fleet-request/sfr-73fbd2ce-aa30-494c-8788-1cee4EXAMPLE. DynamoDB table - The resource type is
        /// table and the unique identifier is the resource ID. Example: table/my-table. DynamoDB global
        /// secondary index - The resource type is index and the unique identifier is the resource ID. Example:
        /// table/my-table/index/my-table-index. Aurora DB cluster - The resource type is cluster and the unique
        /// identifier is the cluster name. Example: cluster:my-db-cluster.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1600
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
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
        /// The value must be less than the forecast interval duration of 3600 seconds (60 minutes). The default
        /// is 300 seconds.
        /// Valid only when configuring predictive scaling.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
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
        /// forecasts capacity but does not apply any scheduled scaling actions based on the capacity forecast.
        /// Required: No
        /// Type: String
        /// Allowed Values: ForecastAndScale | ForecastOnly
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredictiveScalingMode")]
        public Union<string, IntrinsicFunction> PredictiveScalingMode { get; set; }

    }
}
