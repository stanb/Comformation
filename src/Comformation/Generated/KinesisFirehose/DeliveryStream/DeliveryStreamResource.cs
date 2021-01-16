using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html
    /// </summary>
    public class DeliveryStreamResource : ResourceBase
    {
        public class DeliveryStreamProperties
        {
            /// <summary>
            /// DeliveryStreamEncryptionConfigurationInput
            /// Specifies the type and Amazon Resource Name (ARN) of the CMK to use for Server-Side Encryption
            /// (SSE).
            /// Required: No
            /// Type: DeliveryStreamEncryptionConfigurationInput
            /// Update requires: No interruption
            /// </summary>
            public DeliveryStreamEncryptionConfigurationInput DeliveryStreamEncryptionConfigurationInput { get; set; }

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
            /// Allowed values: DirectPut | KinesisStreamAsSource
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
            /// Update requires: Replacement
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

            /// <summary>
            /// HttpEndpointDestinationConfiguration
            /// Enables configuring Kinesis Firehose to deliver data to any HTTP endpoint destination. You can
            /// specify only one destination.
            /// Required: No
            /// Type: HttpEndpointDestinationConfiguration
            /// Update requires: No interruption
            /// </summary>
            public HttpEndpointDestinationConfiguration HttpEndpointDestinationConfiguration { get; set; }

            /// <summary>
            /// Tags
            /// A set of tags to assign to the delivery stream. A tag is a key-value pair that you can define and
            /// assign to AWS resources. Tags are metadata. For example, you can add friendly names and descriptions
            /// or other types of information that can help you distinguish the delivery stream. For more
            /// information about tags, see Using Cost Allocation Tags in the AWS Billing and Cost Management User
            /// Guide.
            /// You can specify up to 50 tags when creating a delivery stream.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::KinesisFirehose::DeliveryStream";

        public DeliveryStreamProperties Properties { get; } = new DeliveryStreamProperties();

    }

    public static class DeliveryStreamAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
