using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.EventSourceMapping
{
    /// <summary>
    /// AWS::Lambda::EventSourceMapping
    /// The AWS::Lambda::EventSourceMapping resource creates a mapping between an event source and an AWS Lambda
    /// function. Lambda reads items from the event source and triggers the function.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html
    /// </summary>
    public class EventSourceMappingResource : ResourceBase
    {
        public class EventSourceMappingProperties
        {
            /// <summary>
            /// BatchSize
            /// The maximum number of items to retrieve in a single batch.
            /// Amazon Kinesis - Default 100. Max 10,000. Amazon DynamoDB Streams - Default 100. Max 1,000. Amazon
            /// Simple Queue Service - Default 10. Max 10.
            /// Required: No
            /// Type: Integer
            /// Minimum: 1
            /// Maximum: 10000
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> BatchSize { get; set; }

            /// <summary>
            /// Enabled
            /// Disables the event source mapping to pause polling and invocation.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> Enabled { get; set; }

            /// <summary>
            /// EventSourceArn
            /// The Amazon Resource Name (ARN) of the event source.
            /// Amazon Kinesis - The ARN of the data stream or a stream consumer. Amazon DynamoDB Streams - The ARN
            /// of the stream. Amazon Simple Queue Service - The ARN of the queue.
            /// Required: Yes
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
            /// StartingPosition
            /// The position in a stream from which to start reading. Required for Amazon Kinesis and Amazon
            /// DynamoDB Streams sources. AT_TIMESTAMP is only supported for Amazon Kinesis streams.
            /// Required: No
            /// Type: String
            /// Allowed Values: AT_TIMESTAMP | LATEST | TRIM_HORIZON
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> StartingPosition { get; set; }

        }

        public string Type { get; } = "AWS::Lambda::EventSourceMapping";

        public EventSourceMappingProperties Properties { get; } = new EventSourceMappingProperties();

    }
}
