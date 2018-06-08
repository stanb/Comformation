using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket SseKmsEncryptedObjects
    /// The SseKmsEncryptedObjects property type specifies the status of whether Amazon S3 replicates objects created
    /// with server-side encryption using an AWS KMS-managed key.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-ssekmsencryptedobjects.html
    /// </summary>
    public class SseKmsEncryptedObjects
    {

        /// <summary>
        /// Status
        /// Specifies whether Amazon S3 replicates objects created with server-side encryption using an AWS
        /// KMS-managed key. Valid values include Enabled and Disabled.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

    }
}
