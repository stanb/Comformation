using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kinesis.Stream
{
    /// <summary>
    /// AWS::Kinesis::Stream
    /// Creates an Kinesis stream that captures and transports data records that are emitted from data sources. For
    /// information about creating streams, see CreateStream in the Amazon Kinesis API Reference.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-stream.html
    /// </summary>
    public class StreamResource : ResourceBase
    {
        public class StreamProperties
        {
            /// <summary>
            /// Name
            /// The name of the Kinesis stream. If you don't specify a name, AWS CloudFormation generates a unique
            /// physical ID and uses that ID for the stream name. For more information, see Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-stream.html#cfn-kinesis-stream-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-stream.html#cfn-kinesis-stream-retentionperiodhours
            /// </summary>
			public Union<int, IntrinsicFunction> RetentionPeriodHours { get; set; }

            /// <summary>
            /// ShardCount
            /// The number of shards that the stream uses. For greater provisioned throughput, increase the number
            /// of shards.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-stream.html#cfn-kinesis-stream-shardcount
            /// </summary>
			public Union<int, IntrinsicFunction> ShardCount { get; set; }

            /// <summary>
            /// StreamEncryption
            /// Enables or updates server-side encryption using an AWS KMS key for a specified stream.
            /// Required: No
            /// Type: Kinesis StreamEncryption
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-stream.html#cfn-kinesis-stream-streamencryption
            /// </summary>
			public Union<StreamEncryption, IntrinsicFunction> StreamEncryption { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) to associate with the Kinesis stream. For information
            /// about constraints for this property, see Tag Restrictions in the Amazon Kinesis Developer Guide.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-stream.html#cfn-kinesis-stream-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::Kinesis::Stream";
        
        public StreamProperties Properties { get; } = new StreamProperties();
    }

	public static class StreamAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
	}
}
