using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.LifecycleHook
{
    /// <summary>
    /// AWS::AutoScaling::LifecycleHook
    /// Defines lifecycle hooks for an Amazon EC2 Auto Scaling group, which specify actions to perform when Amazon EC2
    /// Auto Scaling launches or terminates instances. When you use a lifecycle hook, the Auto Scaling group pauses
    /// the instance either after it is launched (before it is put into service) or as it is terminated (before it is
    /// fully terminated). For more information, see Amazon EC2 Auto Scaling Lifecycle Hooks in the Amazon EC2 Auto
    /// Scaling User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-as-lifecyclehook.html
    /// </summary>
    public class LifecycleHookResource : ResourceBase
    {
        public class LifecycleHookProperties
        {
            /// <summary>
            /// AutoScalingGroupName
            /// The name of the Auto Scaling group for the lifecycle hook.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AutoScalingGroupName { get; set; }

            /// <summary>
            /// DefaultResult
            /// The action the Auto Scaling group takes when the lifecycle hook timeout elapses or if an unexpected
            /// failure occurs. Valid values are CONTINUE and ABANDON (default).
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DefaultResult { get; set; }

            /// <summary>
            /// HeartbeatTimeout
            /// The amount of time (in seconds) that can elapse before the lifecycle hook times out. When the
            /// lifecycle hook times out, Amazon EC2 Auto Scaling performs the action that you specified in the
            /// DefaultResult property.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> HeartbeatTimeout { get; set; }

            /// <summary>
            /// LifecycleHookName
            /// The name of the lifecycle hook. Length Constraints: Minimum length of 1. Maximum length of 255.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LifecycleHookName { get; set; }

            /// <summary>
            /// LifecycleTransition
            /// The state of the Amazon EC2 instance to which you want to attach the lifecycle hook. For valid
            /// values, see the LifecycleTransition details for the PutLifecycleHook action in the Amazon EC2 Auto
            /// Scaling API Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> LifecycleTransition { get; set; }

            /// <summary>
            /// NotificationMetadata
            /// Additional information that you want to include when Amazon EC2 Auto Scaling sends a message to the
            /// notification target.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> NotificationMetadata { get; set; }

            /// <summary>
            /// NotificationTargetARN
            /// The Amazon resource name (ARN) of the notification target that Amazon EC2 Auto Scaling uses to
            /// notify you when an instance is in the transition state for the lifecycle hook. You can specify an
            /// Amazon SQS queue or an Amazon SNS topic. The notification message includes the following
            /// information: lifecycle action token, user account ID, Auto Scaling group name, lifecycle hook name,
            /// instance ID, lifecycle transition, and notification metadata.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> NotificationTargetARN { get; set; }

            /// <summary>
            /// RoleARN
            /// The ARN of the IAM role that allows the Auto Scaling group to publish to the specified notification
            /// target. The role requires permissions to Amazon SNS and Amazon SQS.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RoleARN { get; set; }

        }

        public string Type { get; } = "AWS::AutoScaling::LifecycleHook";

        public LifecycleHookProperties Properties { get; } = new LifecycleHookProperties();

    }
}
