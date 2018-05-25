using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html
    /// </summary>
    public class DeliveryStreamResource : ResourceBase
    {
        public class DeliveryStreamProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-deliverystreamname
            /// </summary>
			public Union<string, IntrinsicFunction> DeliveryStreamName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-deliverystreamtype
            /// </summary>
			public Union<string, IntrinsicFunction> DeliveryStreamType { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration
            /// </summary>
			public Union<ElasticsearchDestinationConfiguration, IntrinsicFunction> ElasticsearchDestinationConfiguration { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration
            /// </summary>
			public Union<ExtendedS3DestinationConfiguration, IntrinsicFunction> ExtendedS3DestinationConfiguration { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-kinesisstreamsourceconfiguration
            /// </summary>
			public Union<KinesisStreamSourceConfiguration, IntrinsicFunction> KinesisStreamSourceConfiguration { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration
            /// </summary>
			public Union<RedshiftDestinationConfiguration, IntrinsicFunction> RedshiftDestinationConfiguration { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-s3destinationconfiguration
            /// </summary>
			public Union<S3DestinationConfiguration, IntrinsicFunction> S3DestinationConfiguration { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration
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
