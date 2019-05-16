using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket TopicConfiguration
    /// A container for specifying the configuration for publication of messages to an Amazon Simple Notification
    /// Service (Amazon SNS) topic when Amazon S3 detects specified events.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig-topicconfig.html
    /// </summary>
    public class TopicConfiguration
    {

        /// <summary>
        /// Event
        /// The Amazon S3 bucket event about which to send notifications. For more information, see Supported
        /// Event Types in the Amazon Simple Storage Service Developer Guide.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Event")]
        public Union<string, IntrinsicFunction> Event { get; set; }

        /// <summary>
        /// Filter
        /// The filtering rules that determine for which objects to send notifications. For example, you can
        /// create a filter so that Amazon S3 sends notifications only when image files with a . jpg extension
        /// are added to the bucket.
        /// Required: No
        /// Type: NotificationFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Filter")]
        public NotificationFilter Filter { get; set; }

        /// <summary>
        /// Topic
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to which Amazon S3 publishes a message when
        /// it detects events of the specified type.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Topic")]
        public Union<string, IntrinsicFunction> Topic { get; set; }

    }
}
