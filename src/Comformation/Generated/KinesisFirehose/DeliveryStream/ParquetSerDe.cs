using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream ParquetSerDe
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-parquetserde.html
    /// </summary>
    public class ParquetSerDe
    {

        /// <summary>
        /// BlockSizeBytes
        /// The Hadoop Distributed File System (HDFS) block size. This is useful if you intend to copy the data
        /// from Amazon S3 to HDFS before querying. The default is 256 MiB and the minimum is 64 MiB. Kinesis
        /// Data Firehose uses this value for padding calculations.
        /// Required: No
        /// Type: Integer
        /// Minimum: 67108864
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlockSizeBytes")]
        public Union<int, IntrinsicFunction> BlockSizeBytes { get; set; }

        /// <summary>
        /// Compression
        /// The compression code to use over data blocks. The possible values are UNCOMPRESSED, SNAPPY, and
        /// GZIP, with the default being SNAPPY. Use SNAPPY for higher decompression speed. Use GZIP if the
        /// compression ratio is more important than speed.
        /// Required: No
        /// Type: String
        /// Allowed values: GZIP | SNAPPY | UNCOMPRESSED
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Compression")]
        public Union<string, IntrinsicFunction> Compression { get; set; }

        /// <summary>
        /// EnableDictionaryCompression
        /// Indicates whether to enable dictionary compression.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnableDictionaryCompression")]
        public Union<bool, IntrinsicFunction> EnableDictionaryCompression { get; set; }

        /// <summary>
        /// MaxPaddingBytes
        /// The maximum amount of padding to apply. This is useful if you intend to copy the data from Amazon S3
        /// to HDFS before querying. The default is 0.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxPaddingBytes")]
        public Union<int, IntrinsicFunction> MaxPaddingBytes { get; set; }

        /// <summary>
        /// PageSizeBytes
        /// The Parquet page size. Column chunks are divided into pages. A page is conceptually an indivisible
        /// unit (in terms of compression and encoding). The minimum value is 64 KiB and the default is 1 MiB.
        /// Required: No
        /// Type: Integer
        /// Minimum: 65536
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PageSizeBytes")]
        public Union<int, IntrinsicFunction> PageSizeBytes { get; set; }

        /// <summary>
        /// WriterVersion
        /// Indicates the version of row format to output. The possible values are V1 and V2. The default is V1.
        /// Required: No
        /// Type: String
        /// Allowed values: V1 | V2
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WriterVersion")]
        public Union<string, IntrinsicFunction> WriterVersion { get; set; }

    }
}
