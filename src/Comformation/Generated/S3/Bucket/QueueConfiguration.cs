using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon Simple Storage Service Bucket QueueConfiguration
    /// QueueConfigurations is a property of the Amazon S3 Bucket NotificationConfiguration property that describes
    /// the S3 bucket events about which you want to send messages to Amazon SQS and the queues to which you want to
    /// send them.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig-queueconfig.html
    /// </summary>
    public class QueueConfiguration
    {

        /// <summary>
        /// Event
        /// The S3 bucket event about which you want to publish messages to Amazon Simple Queue Service ( Amazon
        /// SQS). For more information, see Supported Event Types in the Amazon Simple Storage Service Developer
        /// Guide.
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
        /// Queue
        /// The Amazon Resource Name (ARN) of the Amazon SQS queue that Amazon S3 publishes messages to when the
        /// specified event type occurs.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Queue")]
        public Union<string, IntrinsicFunction> Queue { get; set; }

    }
}
