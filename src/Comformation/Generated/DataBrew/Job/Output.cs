using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Job
{
    /// <summary>
    /// AWS::DataBrew::Job Output
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-output.html
    /// </summary>
    public class Output
    {

        /// <summary>
        /// CompressionFormat
        /// The compression algorithm used to compress the output text of the job.
        /// Required: No
        /// Type: String
        /// Allowed values: BROTLI | BZIP2 | DEFLATE | GZIP | LZ4 | LZO | SNAPPY | ZLIB | ZSTD
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CompressionFormat")]
        public Union<string, IntrinsicFunction> CompressionFormat { get; set; }

        /// <summary>
        /// Format
        /// The data format of the output of the job.
        /// Required: No
        /// Type: String
        /// Allowed values: AVRO | CSV | GLUEPARQUET | JSON | ORC | PARQUET | XML
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Format")]
        public Union<string, IntrinsicFunction> Format { get; set; }

        /// <summary>
        /// PartitionColumns
        /// The names of one or more partition columns for the output of the job.
        /// Required: No
        /// Type: List of String
        /// Maximum: 200
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PartitionColumns")]
        public List<Union<string, IntrinsicFunction>> PartitionColumns { get; set; }

        /// <summary>
        /// Location
        /// The location in Amazon S3 where the job writes its output.
        /// Required: Yes
        /// Type: S3Location
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Location")]
        public S3Location Location { get; set; }

        /// <summary>
        /// Overwrite
        /// A value that, if true, means that any data in the location specified for output is overwritten with
        /// new output.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Overwrite")]
        public Union<bool, IntrinsicFunction> Overwrite { get; set; }

    }
}
