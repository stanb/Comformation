using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3Outposts.Bucket
{
    /// <summary>
    /// AWS::S3Outposts::Bucket Rule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-bucket-rule.html
    /// </summary>
    public class Rule
    {

        /// <summary>
        /// Status
        /// If Enabled, the rule is currently being applied. If Disabled, the rule is not currently being
        /// applied.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

        /// <summary>
        /// Id
        /// The unique identifier for the lifecycle rule. The value can&#39;t be longer than 255 characters.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// AbortIncompleteMultipartUpload
        /// The container for the abort incomplete multipart upload rule.
        /// Required: No
        /// Type: AbortIncompleteMultipartUpload
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AbortIncompleteMultipartUpload")]
        public AbortIncompleteMultipartUpload AbortIncompleteMultipartUpload { get; set; }

        /// <summary>
        /// ExpirationDate
        /// Specifies the expiration for the lifecycle of the object by specifying an expiry date.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExpirationDate")]
        public Union<string, IntrinsicFunction> ExpirationDate { get; set; }

        /// <summary>
        /// ExpirationInDays
        /// Specifies the expiration for the lifecycle of the object in the form of days that the object has
        /// been in the S3 on Outposts bucket.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExpirationInDays")]
        public Union<int, IntrinsicFunction> ExpirationInDays { get; set; }

        /// <summary>
        /// Filter
        /// The container for the filter of the lifecycle rule.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Filter")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Filter { get; set; }

    }
}
