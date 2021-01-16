using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.StorageLens
{
    /// <summary>
    /// AWS::S3::StorageLens S3BucketDestination
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-s3bucketdestination.html
    /// </summary>
    public class S3BucketDestination
    {

        /// <summary>
        /// OutputSchemaVersion
        /// This property contains the details of the output schema version of the S3 Storage Lens export bucket
        /// destination.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputSchemaVersion")]
        public Union<string, IntrinsicFunction> OutputSchemaVersion { get; set; }

        /// <summary>
        /// Format
        /// This property contains the details of the format of the S3 Storage Lens export bucket destination.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Format")]
        public Union<string, IntrinsicFunction> Format { get; set; }

        /// <summary>
        /// AccountId
        /// This property contains the details of the AWS account ID of the S3 Storage Lens export bucket
        /// destination.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccountId")]
        public Union<string, IntrinsicFunction> AccountId { get; set; }

        /// <summary>
        /// Arn
        /// This property contains the details of the ARN of the bucket destination of the S3 Storage Lens
        /// export .
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

        /// <summary>
        /// Prefix
        /// This property contains the details of the prefix of the bucket destination of the S3 Storage Lens
        /// export .
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

    }
}
