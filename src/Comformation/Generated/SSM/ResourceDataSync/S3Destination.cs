using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.ResourceDataSync
{
    /// <summary>
    /// AWS::SSM::ResourceDataSync S3Destination
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-resourcedatasync-s3destination.html
    /// </summary>
    public class S3Destination
    {

        /// <summary>
        /// KMSKeyArn
        /// The ARN of an encryption key for a destination in Amazon S3. Must belong to the same Region as the
        /// destination S3 bucket.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 512
        /// Pattern: arn:. *
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("KMSKeyArn")]
        public Union<string, IntrinsicFunction> KMSKeyArn { get; set; }

        /// <summary>
        /// BucketName
        /// The name of the S3 bucket where the aggregated data is stored.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("BucketName")]
        public Union<string, IntrinsicFunction> BucketName { get; set; }

        /// <summary>
        /// BucketRegion
        /// The AWS Region with the S3 bucket targeted by the Resource Data Sync.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("BucketRegion")]
        public Union<string, IntrinsicFunction> BucketRegion { get; set; }

        /// <summary>
        /// SyncFormat
        /// A supported sync format. The following format is currently supported: JsonSerDe
        /// Required: Yes
        /// Type: String
        /// Allowed values: JsonSerDe
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SyncFormat")]
        public Union<string, IntrinsicFunction> SyncFormat { get; set; }

        /// <summary>
        /// BucketPrefix
        /// An Amazon S3 prefix for the bucket.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("BucketPrefix")]
        public Union<string, IntrinsicFunction> BucketPrefix { get; set; }

    }
}
