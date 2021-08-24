using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// AWS::AutoScaling::AutoScalingGroup LifecycleHookSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-lifecyclehookspecification.html
    /// </summary>
    public class LifecycleHookSpecification
    {

        /// <summary>
        /// DefaultResult
        /// The action the Auto Scaling group takes when the lifecycle hook timeout elapses or if an unexpected
        /// failure occurs. The valid values are CONTINUE and ABANDON (default).
        /// For more information, see Adding lifecycle hooks in the Amazon EC2 Auto Scaling User Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultResult")]
        public Union<string, IntrinsicFunction> DefaultResult { get; set; }

        /// <summary>
        /// HeartbeatTimeout
        /// The maximum time, in seconds, that can elapse before the lifecycle hook times out. If the lifecycle
        /// hook times out, Amazon EC2 Auto Scaling performs the default action.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HeartbeatTimeout")]
        public Union<int, IntrinsicFunction> HeartbeatTimeout { get; set; }

        /// <summary>
        /// LifecycleHookName
        /// The name of the lifecycle hook.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Pattern: [A-Za-z0-9\-_\/]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LifecycleHookName")]
        public Union<string, IntrinsicFunction> LifecycleHookName { get; set; }

        /// <summary>
        /// LifecycleTransition
        /// The state of the EC2 instance to attach the lifecycle hook to. The valid values are:
        /// autoscaling:EC2_INSTANCE_LAUNCHING autoscaling:EC2_INSTANCE_TERMINATING
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LifecycleTransition")]
        public Union<string, IntrinsicFunction> LifecycleTransition { get; set; }

        /// <summary>
        /// NotificationMetadata
        /// Additional information that you want to include any time Amazon EC2 Auto Scaling sends a message to
        /// the notification target.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1023
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NotificationMetadata")]
        public Union<string, IntrinsicFunction> NotificationMetadata { get; set; }

        /// <summary>
        /// NotificationTargetARN
        /// The Amazon Resource Name (ARN) of the notification target that Amazon EC2 Auto Scaling uses to
        /// notify you when an instance is in the transition state for the lifecycle hook. You can specify an
        /// Amazon SQS queue or an Amazon SNS topic.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NotificationTargetARN")]
        public Union<string, IntrinsicFunction> NotificationTargetARN { get; set; }

        /// <summary>
        /// RoleARN
        /// The ARN of the IAM role that allows the Auto Scaling group to publish to the specified notification
        /// target, for example, an Amazon SNS topic or an Amazon SQS queue. For information about creating this
        /// role, see Configuring a notification target for a lifecycle hook in the Amazon EC2 Auto Scaling User
        /// Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleARN")]
        public Union<string, IntrinsicFunction> RoleARN { get; set; }

    }
}
