using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket Destination
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-destination.html
    /// </summary>
    public class Destination
    {

        /// <summary>
        /// BucketAccountId
        /// The account ID that owns the destination S3 bucket. If no account ID is provided, the owner is not
        /// validated before exporting data.
        /// Note Although this value is optional, we strongly recommend that you set it to help prevent problems
        /// if the destination bucket ownership changes.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketAccountId")]
        public Union<string, IntrinsicFunction> BucketAccountId { get; set; }

        /// <summary>
        /// BucketArn
        /// The Amazon Resource Name (ARN) of the bucket to which data is exported.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketArn")]
        public Union<string, IntrinsicFunction> BucketArn { get; set; }

        /// <summary>
        /// Format
        /// Specifies the file format used when exporting data to Amazon S3.
        /// Allowed values: CSV | ORC | Parquet
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Format")]
        public Union<string, IntrinsicFunction> Format { get; set; }

        /// <summary>
        /// Prefix
        /// The prefix to use when exporting data. The prefix is prepended to all results.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

    }
}
