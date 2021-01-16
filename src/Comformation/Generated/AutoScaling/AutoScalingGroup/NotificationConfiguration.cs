using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// AWS::AutoScaling::AutoScalingGroup NotificationConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-notificationconfigurations.html
    /// </summary>
    public class NotificationConfiguration
    {

        /// <summary>
        /// NotificationTypes
        /// A list of event types that trigger a notification. Event types can include any of the following
        /// types.
        /// Allowed Values:
        /// autoscaling:EC2_INSTANCE_LAUNCH autoscaling:EC2_INSTANCE_LAUNCH_ERROR
        /// autoscaling:EC2_INSTANCE_TERMINATE autoscaling:EC2_INSTANCE_TERMINATE_ERROR
        /// autoscaling:TEST_NOTIFICATION
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NotificationTypes")]
        public List<Union<string, IntrinsicFunction>> NotificationTypes { get; set; }

        /// <summary>
        /// TopicARN
        /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service (Amazon SNS) topic.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TopicARN")]
        public Union<string, IntrinsicFunction> TopicARN { get; set; }

    }
}
