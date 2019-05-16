using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.LifecycleHook
{
    /// <summary>
    /// AWS::AutoScaling::LifecycleHook
    /// Defines lifecycle hooks for an Amazon EC2 Auto Scaling group. Lifecycle hooks specify actions to perform when
    /// Amazon EC2 Auto Scaling launches or terminates instances. When you use a lifecycle hook, the Auto Scaling
    /// group pauses the instance either after it is launched (before it is put into service) or as it is terminated
    /// (before it is fully terminated).
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
            /// Minimum: 1
            /// Maximum: 1600
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AutoScalingGroupName { get; set; }

            /// <summary>
            /// DefaultResult
            /// The action the Auto Scaling group takes when the lifecycle hook timeout elapses or if an unexpected
            /// failure occurs. The valid values are CONTINUE and ABANDON (default).
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DefaultResult { get; set; }

            /// <summary>
            /// HeartbeatTimeout
            /// The amount of time, in seconds, that can elapse before the lifecycle hook times out. If the
            /// lifecycle hook times out, Amazon EC2 Auto Scaling performs the action that you specified in the
            /// DefaultResult property.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> HeartbeatTimeout { get; set; }

            /// <summary>
            /// LifecycleHookName
            /// The name of the lifecycle hook.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Pattern: [A-Za-z0-9\-_\/]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LifecycleHookName { get; set; }

            /// <summary>
            /// LifecycleTransition
            /// The instance state to which you want to attach the lifecycle hook. The valid values are:
            /// autoscaling:EC2_INSTANCE_LAUNCHING autoscaling:EC2_INSTANCE_TERMINATING
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> LifecycleTransition { get; set; }

            /// <summary>
            /// NotificationMetadata
            /// Additional information that is included any time Amazon EC2 Auto Scaling sends a message to the
            /// notification target.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1023
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> NotificationMetadata { get; set; }

            /// <summary>
            /// NotificationTargetARN
            /// The Amazon Resource Name (ARN) of the notification target that Amazon EC2 Auto Scaling uses to
            /// notify you when an instance is in the transition state for the lifecycle hook. You can specify an
            /// Amazon SQS queue or an Amazon SNS topic. The notification message includes the following
            /// information: lifecycle action token, user account ID, Auto Scaling group name, lifecycle hook name,
            /// instance ID, lifecycle transition, and notification metadata.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1600
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> NotificationTargetARN { get; set; }

            /// <summary>
            /// RoleARN
            /// The ARN of the IAM role that allows the Auto Scaling group to publish to the specified notification
            /// target, for example, an Amazon SNS topic or an Amazon SQS queue. For information about creating this
            /// role, see Preparing for Notifications in the Amazon EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1600
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RoleARN { get; set; }

        }

        public string Type { get; } = "AWS::AutoScaling::LifecycleHook";

        public LifecycleHookProperties Properties { get; } = new LifecycleHookProperties();

    }
}
