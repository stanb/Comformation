using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// Amazon Kinesis Data Firehose DeliveryStream KinesisStreamSourceConfiguration
    /// 	 The KinesisStreamSourceConfiguration property type specifies the stream and role Amazon Resource Names
    /// (ARNs) for a Kinesis stream used as the source for a delivery stream.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-kinesisstreamsourceconfiguration.html
    /// </summary>
    public class KinesisStreamSourceConfiguration
    {

        /// <summary>
        /// KinesisStreamARN
        /// The Amazon Resource Name (ARN) of the source Kinesis stream.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KinesisStreamARN")]
        public Union<string, IntrinsicFunction> KinesisStreamARN { get; set; }

        /// <summary>
        /// RoleARN
        /// The Amazon Resource Name (ARN) of the role that provides access to the source Kinesis stream.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleARN")]
        public Union<string, IntrinsicFunction> RoleARN { get; set; }

    }
}
