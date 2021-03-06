using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kinesis.Stream
{
    /// <summary>
    /// AWS::Kinesis::Stream
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-stream.html
    /// </summary>
    public class StreamResource : ResourceBase
    {
        public class StreamProperties
        {
            /// <summary>
            /// Name
            /// The name of the Kinesis stream. If you don&#39;t specify a name, AWS CloudFormation generates a unique
            /// physical ID and uses that ID for the stream name. For more information, see Name Type.
            /// If you specify a name, you cannot perform updates that require replacement of this resource. You can
            /// perform updates that require no or some interruption. If you must replace the resource, specify a
            /// new name.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [a-zA-Z0-9_. -]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// RetentionPeriodHours
            /// The number of hours for the data records that are stored in shards to remain accessible. The default
            /// value is 24. For more information about the stream retention period, see Changing the Data Retention
            /// Period in the Amazon Kinesis Developer Guide.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> RetentionPeriodHours { get; set; }

            /// <summary>
            /// ShardCount
            /// The number of shards that the stream uses. For greater provisioned throughput, increase the number
            /// of shards.
            /// Required: Yes
            /// Type: Integer
            /// Minimum: 1
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> ShardCount { get; set; }

            /// <summary>
            /// StreamEncryption
            /// When specified, enables or updates server-side encryption using an AWS KMS key for a specified
            /// stream. Removing this property from your stack template and updating your stack disables encryption.
            /// Required: No
            /// Type: StreamEncryption
            /// Update requires: No interruption
            /// </summary>
            public StreamEncryption StreamEncryption { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) to associate with the Kinesis stream. For information
            /// about constraints for this property, see Tag Restrictions in the Amazon Kinesis Developer Guide.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Kinesis::Stream";

        public StreamProperties Properties { get; } = new StreamProperties();

    }

    public static class StreamAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
