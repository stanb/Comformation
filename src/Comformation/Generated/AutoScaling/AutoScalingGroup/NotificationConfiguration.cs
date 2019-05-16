using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// AWS::AutoScaling::AutoScalingGroup NotificationConfiguration
    /// NotificationConfiguration specifies a list of notification configurations for the NotificationConfigurations
    /// property of AutoScalingGroup. NotificationConfiguration specifies the events that the Amazon EC2 Auto Scaling
    /// group sends notifications for.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-notificationconfigurations.html
    /// </summary>
    public class NotificationConfiguration
    {

        /// <summary>
        /// NotificationTypes
        /// A list of event types that trigger a notification. Event types can include any of the following
        /// types:
        /// autoscaling:EC2_INSTANCE_LAUNCH autoscaling:EC2_INSTANCE_LAUNCH_ERROR
        /// autoscaling:EC2_INSTANCE_TERMINATE autoscaling:EC2_INSTANCE_TERMINATE_ERROR
        /// autoscaling:TEST_NOTIFICATION
        /// Required: No
        /// Type: List of String
        /// Minimum: 1
        /// Maximum: 255
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NotificationTypes")]
        public List<Union<string, IntrinsicFunction>> NotificationTypes { get; set; }

        /// <summary>
        /// TopicARN
        /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service (Amazon SNS) topic.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1600
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TopicARN")]
        public Union<string, IntrinsicFunction> TopicARN { get; set; }

    }
}
