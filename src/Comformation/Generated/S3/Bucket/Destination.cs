using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket Destination
    /// Specifies information about where to publish analysis or configuration results for an Amazon S3 bucket.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-destination.html
    /// </summary>
    public class Destination
    {

        /// <summary>
        /// BucketAccountId
        /// The account ID that owns the destination bucket. If no account ID is provided, the owner will not be
        /// validated prior to exporting data.
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
        /// Required: Yes
        /// Type: String
        /// Allowed Values: CSV
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
