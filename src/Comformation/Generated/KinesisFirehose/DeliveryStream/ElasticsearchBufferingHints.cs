using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// Amazon Kinesis Firehose DeliveryStream ElasticsearchBufferingHints
    /// The ElasticsearchBufferingHints property type specifies how Amazon Kinesis Firehose (Kinesis Firehose) buffers
    /// incoming data while delivering it to the destination. The first buffer condition that is satisfied triggers
    /// Kinesis Firehose to deliver the data.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchbufferinghints.html
    /// </summary>
    public class ElasticsearchBufferingHints
    {

        /// <summary>
        /// IntervalInSeconds
        /// The length of time, in seconds, that Kinesis Firehose buffers incoming data before delivering it to
        /// the destination. For valid values, see the IntervalInSeconds content for the BufferingHints data
        /// type in the Amazon Kinesis Firehose API Reference.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("IntervalInSeconds")]
        public Union<int, IntrinsicFunction> IntervalInSeconds { get; set; }

        /// <summary>
        /// SizeInMBs
        /// The size of the buffer, in MBs, that Kinesis Firehose uses for incoming data before delivering it to
        /// the destination. For valid values, see the SizeInMBs content for the BufferingHints data type in the
        /// Amazon Kinesis Firehose API Reference.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("SizeInMBs")]
        public Union<int, IntrinsicFunction> SizeInMBs { get; set; }

    }
}
