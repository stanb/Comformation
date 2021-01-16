using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream Serializer
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-serializer.html
    /// </summary>
    public class Serializer
    {

        /// <summary>
        /// OrcSerDe
        /// A serializer to use for converting data to the ORC format before storing it in Amazon S3. For more
        /// information, see Apache ORC.
        /// Required: No
        /// Type: OrcSerDe
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OrcSerDe")]
        public OrcSerDe OrcSerDe { get; set; }

        /// <summary>
        /// ParquetSerDe
        /// A serializer to use for converting data to the Parquet format before storing it in Amazon S3. For
        /// more information, see Apache Parquet.
        /// Required: No
        /// Type: ParquetSerDe
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ParquetSerDe")]
        public ParquetSerDe ParquetSerDe { get; set; }

    }
}
