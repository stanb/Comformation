using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket SourceSelectionCriteria
    /// A container that describes additional filters for identifying the source objects that you want to replicate.
    /// You can choose to enable or disable the replication of these objects. Currently, Amazon S3 supports only the
    /// filter that you can specify for objects created with server-side encryption using an AWS KMS-Managed Key
    /// (SSE-KMS).
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-sourceselectioncriteria.html
    /// </summary>
    public class SourceSelectionCriteria
    {

        /// <summary>
        /// SseKmsEncryptedObjects
        /// A container for filter information for the selection of Amazon S3 objects encrypted with AWS KMS. If
        /// you include SourceSelectionCriteria in the replication configuration, this element is required.
        /// Required: Yes
        /// Type: SseKmsEncryptedObjects
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SseKmsEncryptedObjects")]
        public SseKmsEncryptedObjects SseKmsEncryptedObjects { get; set; }

    }
}
