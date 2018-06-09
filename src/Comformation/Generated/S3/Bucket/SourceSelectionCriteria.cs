using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket SourceSelectionCriteria
    /// The SourceSelectionCriteria property type specifies additional filters in identifying source objects that you
    /// want to replicate.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-sourceselectioncriteria.html
    /// </summary>
    public class SourceSelectionCriteria
    {

        /// <summary>
        /// SseKmsEncryptedObjects
        /// Contains the status of whether Amazon S3 replicates objects created with server-side encryption
        /// using an AWS KMS-managed key.
        /// Required: Yes
        /// Type: Amazon S3 Bucket SseKmsEncryptedObjects
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SseKmsEncryptedObjects")]
        public Union<SseKmsEncryptedObjects, IntrinsicFunction> SseKmsEncryptedObjects { get; set; }

    }
}
