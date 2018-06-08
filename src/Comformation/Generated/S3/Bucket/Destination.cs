using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket Destination
    /// The Destination property type specifies information about where to publish analysis or configuration results
    /// for an Amazon S3 bucket.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-destination.html
    /// </summary>
    public class Destination
    {

        /// <summary>
        /// BucketAccountId
        /// The ID of the account that owns the destination bucket where the analytics is published.
        /// Although optional, we recommend that the value be set to prevent problems if the destination bucket
        /// ownership changes.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketAccountId")]
        public Union<string, IntrinsicFunction> BucketAccountId { get; set; }

        /// <summary>
        /// BucketArn
        /// The Amazon Resource Name (ARN) of the bucket where analytics results are published. This destination
        /// bucket must be in the same region as the bucket used for the analytics or inventory configuration.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketArn")]
        public Union<string, IntrinsicFunction> BucketArn { get; set; }

        /// <summary>
        /// Format
        /// Specifies the output format of the analytics or inventory results. Currently, Amazon S3 supports the
        /// comma-separated value (CSV) format.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Format")]
        public Union<string, IntrinsicFunction> Format { get; set; }

        /// <summary>
        /// Prefix
        /// The prefix that is prepended to all analytics results.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

    }
}
