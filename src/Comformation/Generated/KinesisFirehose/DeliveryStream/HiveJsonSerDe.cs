using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream HiveJsonSerDe
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-hivejsonserde.html
    /// </summary>
    public class HiveJsonSerDe
    {

        /// <summary>
        /// TimestampFormats
        /// Indicates how you want Kinesis Data Firehose to parse the date and timestamps that may be present in
        /// your input data JSON. To specify these format strings, follow the pattern syntax of JodaTime&#39;s
        /// DateTimeFormat format strings. For more information, see Class DateTimeFormat. You can also use the
        /// special value millis to parse timestamps in epoch milliseconds. If you don&#39;t specify a format,
        /// Kinesis Data Firehose uses java. sql. Timestamp::valueOf by default.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimestampFormats")]
        public List<Union<string, IntrinsicFunction>> TimestampFormats { get; set; }

    }
}
