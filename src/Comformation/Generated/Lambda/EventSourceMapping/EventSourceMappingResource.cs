using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.EventSourceMapping
{
    /// <summary>
    /// AWS::Lambda::EventSourceMapping
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html
    /// </summary>
    public class EventSourceMappingResource : ResourceBase
    {
        public class EventSourceMappingProperties
        {
            /// <summary>
            /// BatchSize
            /// The maximum number of items to retrieve in a single batch.
            /// 	 Amazon Kinesis - Default 100. Max 10,000. Amazon DynamoDB Streams - Default 100. Max 1,000. Amazon
            /// Simple Queue Service - Default 10. For standard queues the max is 10,000. For FIFO queues the max is
            /// 10. Amazon Managed Streaming for Apache Kafka - Default 100. Max 10,000.
            /// Required: No
            /// Type: Integer
            /// Minimum: 1
            /// Maximum: 10000
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> BatchSize { get; set; }

            /// <summary>
            /// BisectBatchOnFunctionError
            /// (Streams) If the function returns an error, split the batch in two and retry. The default value is
            /// false.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> BisectBatchOnFunctionError { get; set; }

            /// <summary>
            /// DestinationConfig
            /// (Streams) An Amazon SQS queue or Amazon SNS topic destination for discarded records.
            /// Required: No
            /// Type: DestinationConfig
            /// Update requires: No interruption
            /// </summary>
            public DestinationConfig DestinationConfig { get; set; }

            /// <summary>
            /// Enabled
            /// If true, the event source mapping is active. Set to false to pause polling and invocation.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> Enabled { get; set; }

            /// <summary>
            /// EventSourceArn
            /// The Amazon Resource Name (ARN) of the event source.
            /// 	 Amazon Kinesis - The ARN of the data stream or a stream consumer. Amazon DynamoDB Streams - The
            /// ARN of the stream. Amazon Simple Queue Service - The ARN of the queue. Amazon Managed Streaming for
            /// Apache Kafka - The ARN of the cluster.
            /// Required: No
            /// Type: String
            /// Pattern: arn:(aws[a-zA-Z0-9-]*):([a-zA-Z0-9\-])+:([a-z]{2}(-gov)?-[a-z]+-\d{1})?:(\d{12})?:(. *)
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EventSourceArn { get; set; }

            /// <summary>
            /// FunctionName
            /// The name of the Lambda function.
            /// Name formats Function name - MyFunction. Function ARN -
            /// arn:aws:lambda:us-west-2:123456789012:function:MyFunction. Version or Alias ARN -
            /// arn:aws:lambda:us-west-2:123456789012:function:MyFunction:PROD. Partial ARN -
            /// 123456789012:function:MyFunction.
            /// The length constraint applies only to the full ARN. If you specify only the function name, it&#39;s
            /// limited to 64 characters in length.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 140
            /// Pattern:
            /// (arn:(aws[a-zA-Z-]*)?:lambda:)?([a-z]{2}(-gov)?-[a-z]+-\d{1}:)?(\d{12}:)?(function:)?([a-zA-Z0-9-_]+)(:(\$LATEST|[a-zA-Z0-9-_]+))?
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> FunctionName { get; set; }

            /// <summary>
            /// MaximumBatchingWindowInSeconds
            /// (Streams and SQS standard queues) The maximum amount of time to gather records before invoking the
            /// function, in seconds.
            /// Required: No
            /// Type: Integer
            /// Minimum: 0
            /// Maximum: 300
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MaximumBatchingWindowInSeconds { get; set; }

            /// <summary>
            /// MaximumRecordAgeInSeconds
            /// (Streams) Discard records older than the specified age. The default value is infinite (-1). When set
            /// to infinite (-1), failed records are retried until the record expires.
            /// Required: No
            /// Type: Integer
            /// Minimum: -1
            /// Maximum: 604800
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MaximumRecordAgeInSeconds { get; set; }

            /// <summary>
            /// MaximumRetryAttempts
            /// (Streams) Discard records after the specified number of retries. The default value is infinite (-1).
            /// When set to infinite (-1), failed records are retried until the record expires.
            /// Required: No
            /// Type: Integer
            /// Minimum: -1
            /// Maximum: 10000
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MaximumRetryAttempts { get; set; }

            /// <summary>
            /// ParallelizationFactor
            /// (Streams) The number of batches to process from each shard concurrently. The default value is 1.
            /// Required: No
            /// Type: Integer
            /// Minimum: 1
            /// Maximum: 10
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> ParallelizationFactor { get; set; }

            /// <summary>
            /// StartingPosition
            /// The position in a stream from which to start reading. Required for Amazon Kinesis, Amazon DynamoDB,
            /// and Amazon MSK Streams sources.
            /// LATEST - Read only new records. TRIM_HORIZON - Process all available records.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> StartingPosition { get; set; }

            /// <summary>
            /// Topics
            /// The name of the Kafka topic.
            /// Required: No
            /// Type: List of String
            /// Maximum: 1
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Topics { get; set; }

            /// <summary>
            /// Queues
            /// (MQ) The name of the Amazon MQ broker destination queue to consume.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Queues { get; set; }

            /// <summary>
            /// SourceAccessConfigurations
            /// (MQ) The Secrets Manager secret that stores your broker credentials.
            /// Required: No
            /// Type: List of SourceAccessConfiguration
            /// Update requires: No interruption
            /// </summary>
            public List<SourceAccessConfiguration> SourceAccessConfigurations { get; set; }

            /// <summary>
            /// PartialBatchResponse
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> PartialBatchResponse { get; set; }

            /// <summary>
            /// TumblingWindowInSeconds
            /// (Streams) The duration of a processing window in seconds. The range is between 1 second up to 15
            /// minutes.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> TumblingWindowInSeconds { get; set; }

            /// <summary>
            /// FunctionResponseTypes
            /// (Streams) A list of current response type enums applied to the event source mapping.
            /// Valid Values: ReportBatchItemFailures
            /// Required: No
            /// Type: List of String
            /// Maximum: 1
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> FunctionResponseTypes { get; set; }

            /// <summary>
            /// SelfManagedEventSource
            /// The Self-Managed Apache Kafka cluster for your event source.
            /// Required: No
            /// Type: SelfManagedEventSource
            /// Update requires: Replacement
            /// </summary>
            public SelfManagedEventSource SelfManagedEventSource { get; set; }

        }

        public string Type { get; } = "AWS::Lambda::EventSourceMapping";

        public EventSourceMappingProperties Properties { get; } = new EventSourceMappingProperties();

    }

    public static class EventSourceMappingAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
    }
}
