using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket QueueConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig-queueconfig.html
    /// </summary>
    public class QueueConfiguration
    {

        /// <summary>
        /// Event
        /// The Amazon S3 bucket event about which you want to publish messages to Amazon SQS. For more
        /// information, see Supported Event Types in the Amazon Simple Storage Service Developer Guide.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Event")]
        public Union<string, IntrinsicFunction> Event { get; set; }

        /// <summary>
        /// Filter
        /// The filtering rules that determine which objects trigger notifications. For example, you can create
        /// a filter so that Amazon S3 sends notifications only when image files with a . jpg extension are
        /// added to the bucket.
        /// Required: No
        /// Type: NotificationFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Filter")]
        public NotificationFilter Filter { get; set; }

        /// <summary>
        /// Queue
        /// The Amazon Resource Name (ARN) of the Amazon SQS queue to which Amazon S3 publishes a message when
        /// it detects events of the specified type. FIFO queues are not allowed when enabling an SQS queue as
        /// the event notification destination.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Queue")]
        public Union<string, IntrinsicFunction> Queue { get; set; }

    }
}
