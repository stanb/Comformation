using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// Amazon EC2 Auto Scaling AutoScalingGroup LifecycleHookSpecification
    /// The LifecycleHookSpecification property type defines lifecycle hooks for an Amazon EC2 Auto Scaling group,
    /// which specify actions to perform when Amazon EC2 Auto Scaling launches or terminates instances. For more
    /// information, see Amazon EC2 Auto Scaling Lifecycle Hooks in the Amazon EC2 Auto Scaling User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-lifecyclehookspecification.html
    /// </summary>
    public class LifecycleHookSpecification
    {

        /// <summary>
        /// DefaultResult
        /// The action that the Auto Scaling group should take when the lifecycle hook timeout elapses or if an
        /// unexpected failure occurs.
        /// Valid values: CONTINUE, ABANDON (default)
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultResult")]
        public Union<string, IntrinsicFunction> DefaultResult { get; set; }

        /// <summary>
        /// HeartbeatTimeout
        /// The maximum time, in seconds, that can elapse before the lifecycle hook times out. If the lifecycle
        /// hook times out, Auto Scaling performs the default action.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HeartbeatTimeout")]
        public Union<int, IntrinsicFunction> HeartbeatTimeout { get; set; }

        /// <summary>
        /// LifecycleHookName
        /// The name of the lifecycle hook. For constraints, see LifecycleHookSpecification in the Amazon EC2
        /// Auto Scaling API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LifecycleHookName")]
        public Union<string, IntrinsicFunction> LifecycleHookName { get; set; }

        /// <summary>
        /// LifecycleTransition
        /// The state of the EC2 instance to attach the lifecycle hook to. For a list of lifecycle hook types,
        /// see DescribeLifecycleHookTypes in the Amazon EC2 Auto Scaling API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LifecycleTransition")]
        public Union<string, IntrinsicFunction> LifecycleTransition { get; set; }

        /// <summary>
        /// NotificationMetadata
        /// Additional information to include when Amazon EC2 Auto Scaling sends a message to the notification
        /// target. For constraints, see LifecycleHookSpecification in the Amazon EC2 Auto Scaling API
        /// Reference.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NotificationMetadata")]
        public Union<string, IntrinsicFunction> NotificationMetadata { get; set; }

        /// <summary>
        /// NotificationTargetARN
        /// The Amazon Resource Name (ARN) of the target that Amazon EC2 Auto Scaling sends notifications to
        /// when an instance is in the transition state for the lifecycle hook. The notification target can be
        /// either an Amazon SQS queue or an Amazon SNS topic.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NotificationTargetARN")]
        public Union<string, IntrinsicFunction> NotificationTargetARN { get; set; }

        /// <summary>
        /// RoleARN
        /// The ARN of the IAM role that allows the Auto Scaling group to publish to the specified notification
        /// target.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleARN")]
        public Union<string, IntrinsicFunction> RoleARN { get; set; }

    }
}
