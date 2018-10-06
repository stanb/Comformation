using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon Simple Storage Service Bucket TopicConfiguration
    /// Describes the topic and events for the Amazon S3 Bucket NotificationConfiguration property.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig-topicconfig.html
    /// </summary>
    public class TopicConfiguration
    {

        /// <summary>
        /// Event
        /// The Amazon Simple Storage Service (Amazon S3) bucket event about which to send notifications. For
        /// more information, see Supported Event Types in the Amazon Simple Storage Service Developer Guide.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Event")]
        public Union<string, IntrinsicFunction> Event { get; set; }

        /// <summary>
        /// Filter
        /// The filtering rules that determine for which objects to send notifications. For example, you can
        /// create a filter so that Amazon Simple Storage Service (Amazon S3) sends notifications only when
        /// image files with a . jpg extension are added to the bucket.
        /// Required: No
        /// Type: Amazon S3 Bucket NotificationFilter
        /// </summary>
        [JsonProperty("Filter")]
        public NotificationFilter Filter { get; set; }

        /// <summary>
        /// Topic
        /// The Amazon SNS topic Amazon Resource Name (ARN) to which Amazon S3 reports the specified events.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Topic")]
        public Union<string, IntrinsicFunction> Topic { get; set; }

    }
}
