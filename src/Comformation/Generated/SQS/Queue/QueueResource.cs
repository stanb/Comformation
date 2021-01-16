using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SQS.Queue
{
    /// <summary>
    /// AWS::SQS::Queue
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html
    /// </summary>
    public class QueueResource : ResourceBase
    {
        public class QueueProperties
        {
            /// <summary>
            /// ContentBasedDeduplication
            /// For first-in-first-out (FIFO) queues, specifies whether to enable content-based deduplication.
            /// During the deduplication interval, Amazon SQS treats messages that are sent with identical content
            /// as duplicates and delivers only one copy of the message. For more information, see the
            /// ContentBasedDeduplication attribute for the CreateQueue action in the Amazon Simple Queue Service
            /// API Reference.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> ContentBasedDeduplication { get; set; }

            /// <summary>
            /// DelaySeconds
            /// The time in seconds for which the delivery of all messages in the queue is delayed. You can specify
            /// an integer value of 0 to 900 (15 minutes). The default value is 0.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> DelaySeconds { get; set; }

            /// <summary>
            /// FifoQueue
            /// If set to true, creates a FIFO queue. If you don&#39;t specify this property, Amazon SQS creates a
            /// standard queue. For more information, see FIFO (First-In-First-Out) Queues in the Amazon Simple
            /// Queue Service Developer Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> FifoQueue { get; set; }

            /// <summary>
            /// KmsDataKeyReusePeriodSeconds
            /// The length of time in seconds for which Amazon SQS can reuse a data key to encrypt or decrypt
            /// messages before calling AWS KMS again. The value must be an integer between 60 (1 minute) and 86,400
            /// (24 hours). The default is 300 (5 minutes).
            /// Note A shorter time period provides better security, but results in more calls to AWS KMS, which
            /// might incur charges after Free Tier. For more information, see How Does the Data Key Reuse Period
            /// Work? in the Amazon Simple Queue Service Developer Guide.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> KmsDataKeyReusePeriodSeconds { get; set; }

            /// <summary>
            /// KmsMasterKeyId
            /// The ID of an AWS managed customer master key (CMK) for Amazon SQS or a custom CMK. To use the AWS
            /// managed CMK for Amazon SQS, specify the (default) alias alias/aws/sqs. For more information, see the
            /// following:
            /// Protecting Data Using Server-Side Encryption (SSE) and AWS KMS in the Amazon Simple Queue Service
            /// Developer Guide CreateQueue in the Amazon Simple Queue Service API Reference The Customer Master
            /// Keys section of the AWS Key Management Service Best Practices whitepaper
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> KmsMasterKeyId { get; set; }

            /// <summary>
            /// MaximumMessageSize
            /// The limit of how many bytes that a message can contain before Amazon SQS rejects it. You can specify
            /// an integer value from 1,024 bytes (1 KiB) to 262,144 bytes (256 KiB). The default value is 262,144
            /// (256 KiB).
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MaximumMessageSize { get; set; }

            /// <summary>
            /// MessageRetentionPeriod
            /// The number of seconds that Amazon SQS retains a message. You can specify an integer value from 60
            /// seconds (1 minute) to 1,209,600 seconds (14 days). The default value is 345,600 seconds (4 days).
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MessageRetentionPeriod { get; set; }

            /// <summary>
            /// QueueName
            /// A name for the queue. To create a FIFO queue, the name of your FIFO queue must end with the . fifo
            /// suffix. For more information, see FIFO (First-In-First-Out) Queues in the Amazon Simple Queue
            /// Service Developer Guide.
            /// If you don&#39;t specify a name, AWS CloudFormation generates a unique physical ID and uses that ID for
            /// the queue name. For more information, see Name Type in the AWS CloudFormation User Guide.
            /// Important If you specify a name, you can&#39;t perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> QueueName { get; set; }

            /// <summary>
            /// ReceiveMessageWaitTimeSeconds
            /// Specifies the duration, in seconds, that the ReceiveMessage action call waits until a message is in
            /// the queue in order to include it in the response, rather than returning an empty response if a
            /// message isn&#39;t yet available. You can specify an integer from 1 to 20. Short polling is used as the
            /// default or when you specify 0 for this property. For more information, see Amazon SQS Long Poll.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> ReceiveMessageWaitTimeSeconds { get; set; }

            /// <summary>
            /// RedrivePolicy
            /// A string that includes the parameters for the dead-letter queue functionality (redrive policy) of
            /// the source queue. For more information about the redrive policy and dead-letter queues, see Using
            /// Amazon SQS Dead-Letter Queues in the Amazon Simple Queue Service Developer Guide.
            /// Note The dead-letter queue of a FIFO queue must also be a FIFO queue. Similarly, the dead-letter
            /// queue of a standard queue must also be a standard queue.
            /// JSON
            /// { &quot;deadLetterTargetArn&quot; : String, &quot;maxReceiveCount&quot; : Integer }
            /// YAML
            /// deadLetterTargetArn : String
            /// maxReceiveCount : Integer
            /// deadLetterTargetArn – The Amazon Resource Name (ARN) of the dead-letter queue to which Amazon SQS
            /// moves messages after the value of maxReceiveCount is exceeded. maxReceiveCount – The number of times
            /// a message is delivered to the source queue before being moved to the dead-letter queue.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> RedrivePolicy { get; set; }

            /// <summary>
            /// Tags
            /// The tags that you attach to this queue. For more information, see Resource Tag in the AWS
            /// CloudFormation User Guide.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// VisibilityTimeout
            /// The length of time during which a message will be unavailable after a message is delivered from the
            /// queue. This blocks other components from receiving the same message and gives the initial component
            /// time to process and delete the message from the queue.
            /// Values must be from 0 to 43,200 seconds (12 hours). If you don&#39;t specify a value, AWS CloudFormation
            /// uses the default value of 30 seconds.
            /// For more information about Amazon SQS queue visibility timeouts, see Visibility Timeout in the
            /// Amazon Simple Queue Service Developer Guide.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> VisibilityTimeout { get; set; }

        }

        public string Type { get; } = "AWS::SQS::Queue";

        public QueueProperties Properties { get; } = new QueueProperties();

    }

    public static class QueueAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> QueueName = new ResourceAttribute<Union<string, IntrinsicFunction>>("QueueName");
    }
}
