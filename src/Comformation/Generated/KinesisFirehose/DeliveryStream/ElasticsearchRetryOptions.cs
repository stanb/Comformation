using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream ElasticsearchRetryOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchretryoptions.html
    /// </summary>
    public class ElasticsearchRetryOptions
    {

        /// <summary>
        /// DurationInSeconds
        /// After an initial failure to deliver to Amazon ES, the total amount of time during which Kinesis Data
        /// Firehose re-attempts delivery (including the first attempt). If Kinesis Data Firehose can&#39;t deliver
        /// the data within the specified time, it writes the data to the backup S3 bucket. For valid values,
        /// see the DurationInSeconds content for the ElasticsearchRetryOptions data type in the Amazon Kinesis
        /// Data Firehose API Reference.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 7200
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DurationInSeconds")]
        public Union<int, IntrinsicFunction> DurationInSeconds { get; set; }

    }
}
