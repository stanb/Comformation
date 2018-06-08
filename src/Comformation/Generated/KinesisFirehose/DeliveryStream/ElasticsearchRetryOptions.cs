using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// Amazon Kinesis Firehose DeliveryStream ElasticsearchRetryOptions
    /// The ElasticsearchRetryOptions property type configures the retry behavior for when Amazon Kinesis Firehose
    /// (Kinesis Firehose) can't deliver data to Amazon Elasticsearch Service (Amazon ES).
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchretryoptions.html
    /// </summary>
    public class ElasticsearchRetryOptions
    {

        /// <summary>
        /// DurationInSeconds
        /// After an initial failure to deliver to Amazon ES, the total amount of time during which Kinesis
        /// Firehose re-attempts delivery (including the first attempt). If Kinesis Firehose can't deliver the
        /// data within the specified time, it writes the data to the backup S3 bucket. For valid values, see
        /// the DurationInSeconds content for the ElasticsearchRetryOptions data type in the Amazon Kinesis
        /// Firehose API Reference.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("DurationInSeconds")]
        public Union<int, IntrinsicFunction> DurationInSeconds { get; set; }

    }
}
