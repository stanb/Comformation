using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream OrcSerDe
    /// A serializer to use for converting data to the ORC format before storing it in Amazon S3. For more
    /// information, see Apache ORC.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-orcserde.html
    /// </summary>
    public class OrcSerDe
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
        /// BloomFilterColumns
        /// The column names for which you want Kinesis Data Firehose to create bloom filters. The default is
        /// null.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BloomFilterColumns")]
        public List<Union<string, IntrinsicFunction>> BloomFilterColumns { get; set; }

        /// <summary>
        /// BloomFilterFalsePositiveProbability
        /// The Bloom filter false positive probability (FPP). The lower the FPP, the bigger the Bloom filter.
        /// The default value is 0. 05, the minimum is 0, and the maximum is 1.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BloomFilterFalsePositiveProbability")]
        public Union<double, IntrinsicFunction> BloomFilterFalsePositiveProbability { get; set; }

        /// <summary>
        /// Compression
        /// The compression code to use over data blocks. The default is SNAPPY.
        /// Required: No
        /// Type: String
        /// Allowed Values: NONE | SNAPPY | ZLIB
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Compression")]
        public Union<string, IntrinsicFunction> Compression { get; set; }

        /// <summary>
        /// DictionaryKeyThreshold
        /// Represents the fraction of the total number of non-null rows. To turn off dictionary encoding, set
        /// this fraction to a number that is less than the number of distinct keys in a dictionary. To always
        /// use dictionary encoding, set this threshold to 1.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DictionaryKeyThreshold")]
        public Union<double, IntrinsicFunction> DictionaryKeyThreshold { get; set; }

        /// <summary>
        /// EnablePadding
        /// Set this to true to indicate that you want stripes to be padded to the HDFS block boundaries. This
        /// is useful if you intend to copy the data from Amazon S3 to HDFS before querying. The default is
        /// false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnablePadding")]
        public Union<bool, IntrinsicFunction> EnablePadding { get; set; }

        /// <summary>
        /// FormatVersion
        /// The version of the file to write. The possible values are V0_11 and V0_12. The default is V0_12.
        /// Required: No
        /// Type: String
        /// Allowed Values: V0_11 | V0_12
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FormatVersion")]
        public Union<string, IntrinsicFunction> FormatVersion { get; set; }

        /// <summary>
        /// PaddingTolerance
        /// A number between 0 and 1 that defines the tolerance for block padding as a decimal fraction of
        /// stripe size. The default value is 0. 05, which means 5 percent of stripe size.
        /// For the default values of 64 MiB ORC stripes and 256 MiB HDFS blocks, the default block padding
        /// tolerance of 5 percent reserves a maximum of 3. 2 MiB for padding within the 256 MiB block. In such
        /// a case, if the available size within the block is more than 3. 2 MiB, a new, smaller stripe is
        /// inserted to fit within that space. This ensures that no stripe crosses block boundaries and causes
        /// remote reads within a node-local task.
        /// Kinesis Data Firehose ignores this parameter when EnablePadding is false.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PaddingTolerance")]
        public Union<double, IntrinsicFunction> PaddingTolerance { get; set; }

        /// <summary>
        /// RowIndexStride
        /// The number of rows between index entries. The default is 10,000 and the minimum is 1,000.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RowIndexStride")]
        public Union<int, IntrinsicFunction> RowIndexStride { get; set; }

        /// <summary>
        /// StripeSizeBytes
        /// The number of bytes in each stripe. The default is 64 MiB and the minimum is 8 MiB.
        /// Required: No
        /// Type: Integer
        /// Minimum: 8388608
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StripeSizeBytes")]
        public Union<int, IntrinsicFunction> StripeSizeBytes { get; set; }

    }
}
