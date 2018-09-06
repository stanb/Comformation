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
            /// A name for the delivery stream.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DeliveryStreamName { get; set; }

            /// <summary>
            /// DeliveryStreamType
            /// The delivery stream type. This property can be one of the following values:
            /// DirectPut: Provider applications access the delivery stream directly. KinesisStreamAsSource: The
            /// delivery stream uses a Kinesis stream as a source.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DeliveryStreamType { get; set; }

            /// <summary>
            /// ElasticsearchDestinationConfiguration
            /// An Amazon ES destination for the delivery stream.
            /// Required: Conditional. You must specify only one destination configuration.
            /// Type: Kinesis Data Firehose DeliveryStream ElasticsearchDestinationConfiguration
            /// Update requires: No interruption. If you change the delivery stream destination from an Amazon ES
            /// destination to an Amazon S3 or Amazon Redshift destination, update requires some interruptions.
            /// </summary>
			public Union<ElasticsearchDestinationConfiguration, IntrinsicFunction> ElasticsearchDestinationConfiguration { get; set; }

            /// <summary>
            /// ExtendedS3DestinationConfiguration
            /// An Amazon S3 destination for the delivery stream.
            /// Required: Conditional. You must specify only one destination configuration.
            /// Type: Kinesis Data Firehose DeliveryStream ExtendedS3DestinationConfiguration
            /// Update requires: No interruption. If you change the delivery stream destination from an Amazon
            /// Redshift destination to an Amazon ES destination, update requires some interruptions.
            /// </summary>
			public Union<ExtendedS3DestinationConfiguration, IntrinsicFunction> ExtendedS3DestinationConfiguration { get; set; }

            /// <summary>
            /// KinesisStreamSourceConfiguration
            /// When a Kinesis stream is used as the source for the delivery stream, a Kinesis Data Firehose
            /// DeliveryStream KinesisStreamSourceConfiguration containing the Kinesis stream ARN and the role ARN
            /// for the source stream.
            /// Required: No
            /// Type: Kinesis Data Firehose DeliveryStream KinesisStreamSourceConfiguration
            /// Update requires: No interruption
            /// </summary>
			public Union<KinesisStreamSourceConfiguration, IntrinsicFunction> KinesisStreamSourceConfiguration { get; set; }

            /// <summary>
            /// RedshiftDestinationConfiguration
            /// An Amazon Redshift destination for the delivery stream.
            /// Required: Conditional. You must specify only one destination configuration.
            /// Type: Kinesis Data Firehose DeliveryStream RedshiftDestinationConfiguration
            /// Update requires: No interruption. If you change the delivery stream destination from an Amazon
            /// Redshift destination to an Amazon ES destination, update requires some interruptions.
            /// </summary>
			public Union<RedshiftDestinationConfiguration, IntrinsicFunction> RedshiftDestinationConfiguration { get; set; }

            /// <summary>
            /// S3DestinationConfiguration
            /// An Amazon S3 destination for the delivery stream.
            /// Required: Conditional. You must specify only one destination configuration.
            /// Type: Kinesis Data Firehose DeliveryStream S3DestinationConfiguration
            /// Update requires: No interruption. If you change the delivery stream destination from an Amazon S3
            /// destination to an Amazon ES destination, update requires some interruptions.
            /// </summary>
			public Union<S3DestinationConfiguration, IntrinsicFunction> S3DestinationConfiguration { get; set; }

            /// <summary>
            /// SplunkDestinationConfiguration
            /// The configuration of a destination in Splunk for the delivery stream.
            /// Required: No
            /// Type: Kinesis Data Firehose DeliveryStream SplunkDestinationConfiguration
            /// Update requires: No interruption
            /// </summary>
			public Union<SplunkDestinationConfiguration, IntrinsicFunction> SplunkDestinationConfiguration { get; set; }

        }
    
        public string Type { get; } = "AWS::KinesisFirehose::DeliveryStream";
        
        public DeliveryStreamProperties Properties { get; } = new DeliveryStreamProperties();
    }

	public static class DeliveryStreamAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
	}
}
