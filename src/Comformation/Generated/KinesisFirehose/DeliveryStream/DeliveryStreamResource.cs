using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream
    /// The AWS::KinesisFirehose::DeliveryStream resource creates an Amazon Kinesis Data Firehose (Kinesis Data
    /// Firehose) delivery stream that delivers real-time streaming data to an Amazon Simple Storage Service (Amazon
    /// S3), Amazon Redshift, or Amazon Elasticsearch Service (Amazon ES) destination. For more information, see
    /// Creating an Amazon Kinesis Data Firehose Delivery Stream in the Amazon Kinesis Data Firehose Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html
    /// </summary>
    public class DeliveryStreamResource : ResourceBase
    {
        public class DeliveryStreamProperties
        {
            /// <summary>
            /// DeliveryStreamName
            /// The name of the delivery stream.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: [a-zA-Z0-9_. -]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DeliveryStreamName { get; set; }

            /// <summary>
            /// DeliveryStreamType
            /// The delivery stream type. This can be one of the following values:
            /// DirectPut: Provider applications access the delivery stream directly. KinesisStreamAsSource: The
            /// delivery stream uses a Kinesis data stream as a source.
            /// Required: No
            /// Type: String
            /// Allowed Values: DirectPut | KinesisStreamAsSource
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DeliveryStreamType { get; set; }

            /// <summary>
            /// ElasticsearchDestinationConfiguration
            /// An Amazon ES destination for the delivery stream.
            /// Conditional. You must specify only one destination configuration.
            /// If you change the delivery stream destination from an Amazon ES destination to an Amazon S3 or
            /// Amazon Redshift destination, update requires some interruptions.
            /// Required: Conditional
            /// Type: ElasticsearchDestinationConfiguration
            /// Update requires: No interruption
            /// </summary>
			public ElasticsearchDestinationConfiguration ElasticsearchDestinationConfiguration { get; set; }

            /// <summary>
            /// ExtendedS3DestinationConfiguration
            /// An Amazon S3 destination for the delivery stream.
            /// Conditional. You must specify only one destination configuration.
            /// If you change the delivery stream destination from an Amazon Extended S3 destination to an Amazon ES
            /// destination, update requires some interruptions.
            /// Required: Conditional
            /// Type: ExtendedS3DestinationConfiguration
            /// Update requires: No interruption
            /// </summary>
			public ExtendedS3DestinationConfiguration ExtendedS3DestinationConfiguration { get; set; }

            /// <summary>
            /// KinesisStreamSourceConfiguration
            /// When a Kinesis stream is used as the source for the delivery stream, a
            /// KinesisStreamSourceConfiguration containing the Kinesis stream ARN and the role ARN for the source
            /// stream.
            /// Required: No
            /// Type: KinesisStreamSourceConfiguration
            /// Update requires: No interruption
            /// </summary>
			public KinesisStreamSourceConfiguration KinesisStreamSourceConfiguration { get; set; }

            /// <summary>
            /// RedshiftDestinationConfiguration
            /// An Amazon Redshift destination for the delivery stream.
            /// Conditional. You must specify only one destination configuration.
            /// If you change the delivery stream destination from an Amazon Redshift destination to an Amazon ES
            /// destination, update requires some interruptions.
            /// Required: Conditional
            /// Type: RedshiftDestinationConfiguration
            /// Update requires: No interruption
            /// </summary>
			public RedshiftDestinationConfiguration RedshiftDestinationConfiguration { get; set; }

            /// <summary>
            /// S3DestinationConfiguration
            /// The S3DestinationConfiguration property type specifies an Amazon Simple Storage Service (Amazon S3)
            /// destination to which Amazon Kinesis Data Firehose (Kinesis Data Firehose) delivers data.
            /// Conditional. You must specify only one destination configuration.
            /// If you change the delivery stream destination from an Amazon S3 destination to an Amazon ES
            /// destination, update requires some interruptions.
            /// Required: Conditional
            /// Type: S3DestinationConfiguration
            /// Update requires: No interruption
            /// </summary>
			public S3DestinationConfiguration S3DestinationConfiguration { get; set; }

            /// <summary>
            /// SplunkDestinationConfiguration
            /// The configuration of a destination in Splunk for the delivery stream.
            /// Required: No
            /// Type: SplunkDestinationConfiguration
            /// Update requires: No interruption
            /// </summary>
			public SplunkDestinationConfiguration SplunkDestinationConfiguration { get; set; }

        }

        public string Type { get; } = "AWS::KinesisFirehose::DeliveryStream";

        public DeliveryStreamProperties Properties { get; } = new DeliveryStreamProperties();

    }

	public static class DeliveryStreamAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
