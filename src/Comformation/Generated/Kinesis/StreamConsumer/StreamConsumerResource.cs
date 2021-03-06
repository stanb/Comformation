using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kinesis.StreamConsumer
{
    /// <summary>
    /// AWS::Kinesis::StreamConsumer
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-streamconsumer.html
    /// </summary>
    public class StreamConsumerResource : ResourceBase
    {
        public class StreamConsumerProperties
        {
            /// <summary>
            /// ConsumerName
            /// The name of the consumer is something you choose when you register the consumer.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [a-zA-Z0-9_. -]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ConsumerName { get; set; }

            /// <summary>
            /// StreamARN
            /// The ARN of the stream with which you registered the consumer.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Pattern: arn:aws. *:kinesis:. *:\d{12}:stream/. +
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> StreamARN { get; set; }

        }

        public string Type { get; } = "AWS::Kinesis::StreamConsumer";

        public StreamConsumerProperties Properties { get; } = new StreamConsumerProperties();

    }

    public static class StreamConsumerAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ConsumerCreationTimestamp = new ResourceAttribute<Union<string, IntrinsicFunction>>("ConsumerCreationTimestamp");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ConsumerName = new ResourceAttribute<Union<string, IntrinsicFunction>>("ConsumerName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ConsumerARN = new ResourceAttribute<Union<string, IntrinsicFunction>>("ConsumerARN");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ConsumerStatus = new ResourceAttribute<Union<string, IntrinsicFunction>>("ConsumerStatus");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> StreamARN = new ResourceAttribute<Union<string, IntrinsicFunction>>("StreamARN");
    }
}
