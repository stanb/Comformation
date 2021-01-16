using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream Deserializer
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-deserializer.html
    /// </summary>
    public class Deserializer
    {

        /// <summary>
        /// HiveJsonSerDe
        /// The native Hive / HCatalog JsonSerDe. Used by Kinesis Data Firehose for deserializing data, which
        /// means converting it from the JSON format in preparation for serializing it to the Parquet or ORC
        /// format. This is one of two deserializers you can choose, depending on which one offers the
        /// functionality you need. The other option is the OpenX SerDe.
        /// Required: No
        /// Type: HiveJsonSerDe
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HiveJsonSerDe")]
        public HiveJsonSerDe HiveJsonSerDe { get; set; }

        /// <summary>
        /// OpenXJsonSerDe
        /// The OpenX SerDe. Used by Kinesis Data Firehose for deserializing data, which means converting it
        /// from the JSON format in preparation for serializing it to the Parquet or ORC format. This is one of
        /// two deserializers you can choose, depending on which one offers the functionality you need. The
        /// other option is the native Hive / HCatalog JsonSerDe.
        /// Required: No
        /// Type: OpenXJsonSerDe
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OpenXJsonSerDe")]
        public OpenXJsonSerDe OpenXJsonSerDe { get; set; }

    }
}
