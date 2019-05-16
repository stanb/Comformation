using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket SseKmsEncryptedObjects
    /// A container for filter information for the selection of S3 objects encrypted with AWS KMS.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-ssekmsencryptedobjects.html
    /// </summary>
    public class SseKmsEncryptedObjects
    {

        /// <summary>
        /// Status
        /// Specifies whether Amazon S3 replicates objects created with server-side encryption using an AWS
        /// KMS-managed key.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: Disabled | Enabled
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

    }
}
