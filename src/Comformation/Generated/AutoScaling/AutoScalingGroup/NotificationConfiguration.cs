using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// Amazon EC2 Auto Scaling AutoScalingGroup NotificationConfiguration
    /// The NotificationConfiguration property type specifies the events that the Auto Scaling group sends
    /// notifications for.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-notificationconfigurations.html
    /// </summary>
    public class NotificationConfiguration
    {

        /// <summary>
        /// NotificationTypes
        /// A list of event types that trigger a notification. Event types can include any of the following
        /// types: autoscaling:EC2_INSTANCE_LAUNCH, autoscaling:EC2_INSTANCE_LAUNCH_ERROR,
        /// autoscaling:EC2_INSTANCE_TERMINATE, autoscaling:EC2_INSTANCE_TERMINATE_ERROR, and
        /// autoscaling:TEST_NOTIFICATION. For more information about event types, see
        /// DescribeAutoScalingNotificationTypes in the Amazon EC2 Auto Scaling API Reference.
        /// Required: Yes
        /// Type: List of String values
        /// </summary>
        [JsonProperty("NotificationTypes")]
        public List<Union<string, IntrinsicFunction>> NotificationTypes { get; set; }

        /// <summary>
        /// TopicARN
        /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service (SNS) topic.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("TopicARN")]
        public Union<string, IntrinsicFunction> TopicARN { get; set; }

    }
}
